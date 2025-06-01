using MCSA_API.Data;
using MCSA_API.Domain.Dates;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;
using MCSA_API.Domain.Moderation.Stats;
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
            MissingPersonsStats = await BuildMissingPersonsStatsAsync(),
            StatsByProvince = await BuildStatsByProvinceAsync()
        };
    }

    private async Task<MissingPersonsStats> BuildMissingPersonsStatsAsync()
    {
        var items = await missingPersonRepository.GetAllAsync();

        var now = dateProvider.GetDate();

        var recentlyReportedStartDate = now.AddDays(-RecencyInDays);

        return new MissingPersonsStats
        {
            RecentlyReported = items.Count(i => i.Created >= recentlyReportedStartDate),
            TotalReported = items.Count(),
            Males = items.Count(i => i.Gender == Gender.Male),
            Females = items.Count(i => i.Gender == Gender.Female)
        };
    }

    private async Task<List<StatByProvince>> BuildStatsByProvinceAsync()
    {
        var statsByProvince = new List<StatByProvince>();

        var items = await missingPersonRepository.GetAllAsync();

        foreach (var province in EnumHelper.GetValues<Province>())
        {
            statsByProvince.Add(new StatByProvince
            {
                Province = province.GetBestDescription(),
                Count = items.Count(i => i.Province == province)
            });
        }

        return statsByProvince;
    }
}