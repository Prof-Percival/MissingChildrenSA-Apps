using MCSA_API.Domain.Statistics;
using MCSA_API.Models.Moderation.Stats;

namespace MCSA_API.Models.Statistics;

public sealed class MainStatisticsModel
{
    public ModerationQueueStatsResponseModel ModerationQueueStats { get; init; }
    public MissingPersonsStatsModel MissingPersonsStats { get; init; }
    public List<StatByProvinceModel> StatsByProvince { get; init; }

    public static MainStatisticsModel Create(MainStatistics statistics)
    {
        return new MainStatisticsModel
        {
            ModerationQueueStats = new ModerationQueueStatsResponseModel(statistics.ModerationQueueStats),
            MissingPersonsStats = new MissingPersonsStatsModel(statistics.MissingPersonsStats),
            StatsByProvince = statistics.StatsByProvince.ConvertAll(item => new StatByProvinceModel(item))
        };
    }
}