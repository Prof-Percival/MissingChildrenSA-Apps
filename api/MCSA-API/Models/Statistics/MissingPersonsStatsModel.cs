using MCSA_API.Domain.Moderation.Stats;

namespace MCSA_API.Models.Statistics;

public sealed class MissingPersonsStatsModel(
    MissingPersonsStats stats)
{
    public int RecentlyReported { get; } = stats.RecentlyReported;
    public int TotalReported { get; } = stats.TotalReported;
    public int Males { get; } = stats.Males;
    public int Females { get; } = stats.Females;
}