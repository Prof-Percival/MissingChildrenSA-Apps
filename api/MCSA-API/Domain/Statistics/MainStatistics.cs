using MCSA_API.Domain.Moderation.Stats;

namespace MCSA_API.Domain.Statistics;

public sealed class MainStatistics
{
    public ModerationQueueStats ModerationQueueStats { get; init; }
    public MissingPersonsStats MissingPersonsStats { get; init; }
    public List<StatByProvince> StatsByProvince { get; init; }
}