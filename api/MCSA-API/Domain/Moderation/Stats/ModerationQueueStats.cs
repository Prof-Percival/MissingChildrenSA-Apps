namespace MCSA_API.Domain.Moderation.Stats;

public sealed class ModerationQueueStats
{
    public int Unmoderated { get; init; }
    public int InModeration { get; init; }
    public int Failed { get; init; }
    public int Approved { get; init; }
}