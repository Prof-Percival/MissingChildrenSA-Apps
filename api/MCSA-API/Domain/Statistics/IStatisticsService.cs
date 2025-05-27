namespace MCSA_API.Domain.Statistics;

public interface IStatisticsService
{
    Task<MainStatistics> GetMainStatisticsAsync();
}