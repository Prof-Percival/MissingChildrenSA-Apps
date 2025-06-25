using MCSA_API.Data;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;
using MCSA_API.Domain.Moderation.Stats;
using MCSA_API.Extensions;
using MCSA_API.Helpers;

namespace MCSA_API.Domain.Statistics;

public sealed class StatisticsService(
    IModerationService moderationService,
    IRepository<MissingPerson> missingPersonRepository,
    IDateProvider dateProvider) : IStatisticsService
{
    private const int RecencyInDays = 7;

    public async Task<MainStatistics> GetMainStatisticsAsync()
    {
        return new MainStatistics
        {
            ModerationQueueStats = await moderationService.GetModerationQueueStats(),
            MissingPersonsStats = await BuildMissingPersonsStatsAsync(),
            StatsByProvince = await BuildStatsByProvinceAsync()
        };
    }

    public async Task<MissingPersonsStatistics> GetMissingPersonsStatistics()
    {
        return new MissingPersonsStatistics
        {
            MissingPersonsStats = await BuildMissingPersonsStatsAsync([ModerationStatus.Approved]),
            StatsByProvince = await BuildStatsByProvinceAsync([ModerationStatus.Approved])
        };
    }

    private async Task<MissingPersonsStats> BuildMissingPersonsStatsAsync(HashSet<ModerationStatus> statuses = null)
    {
        var allMissingPersons = await missingPersonRepository.GetAllAsync();

        var missingPersons = allMissingPersons.Where(Filter(statuses)).ToList();

        var now = dateProvider.GetDate();

        var recentlyReportedStartDate = now.AddDays(-RecencyInDays);

        return new MissingPersonsStats
        {
            RecentlyReported = missingPersons.Count(i => i.Created >= recentlyReportedStartDate),
            TotalReported = missingPersons.Count(),
            Males = missingPersons.Count(i => i.Gender == Gender.Male),
            Females = missingPersons.Count(i => i.Gender == Gender.Female)
        };
    }

    private async Task<List<StatByProvince>> BuildStatsByProvinceAsync(HashSet<ModerationStatus> statuses = null)
    {
        var statsByProvince = new List<StatByProvince>();

        var allMissingPersons = await missingPersonRepository.GetAllAsync();

        var missingPersons = allMissingPersons.Where(Filter(statuses)).ToList();

        foreach (var province in EnumHelper.GetValues<Province>())
        {
            statsByProvince.Add(new StatByProvince
            {
                Province = province.GetBestDescription(),
                Count = missingPersons.Count(i => i.Province == province)
            });
        }

        return statsByProvince;
    }

    private static Func<MissingPerson, bool> Filter(HashSet<ModerationStatus> statuses)
    {
        return (missingPerson) => statuses.IsNullOrEmpty() || statuses.Contains(missingPerson.ModerationStatus);
    }
}