using MCSA_API.Domain.Statistics;

namespace MCSA_API.Models.Statistics;

public sealed class MissingPersonsStatisticsModel
{
    public MissingPersonsStatsModel MissingPersonsStats { get; init; }
    public List<StatByProvinceModel> StatsByProvince { get; init; }

    public static MissingPersonsStatisticsModel Create(MissingPersonsStatistics statistics)
    {
        return new MissingPersonsStatisticsModel
        {
            MissingPersonsStats = new MissingPersonsStatsModel(statistics.MissingPersonsStats),
            StatsByProvince = statistics.StatsByProvince.ConvertAll(item => new StatByProvinceModel(item))
        };
    }
}