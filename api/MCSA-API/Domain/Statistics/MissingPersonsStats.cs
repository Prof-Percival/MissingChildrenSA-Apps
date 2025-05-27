namespace MCSA_API.Domain.Moderation.Stats;

public sealed class MissingPersonsStats
{
    public int RecentlyReported { get; init; }
    public int TotalReported { get; init; }
    public int Males { get; init; }
    public int Females { get; init; }
}