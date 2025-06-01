using MCSA_API.Domain.Moderation.Stats;

namespace MCSA_API.Domain.Statistics;

public sealed class MainStatistics : MissingPersonsStatistics
{
    public ModerationQueueStats ModerationQueueStats { get; init; }
}