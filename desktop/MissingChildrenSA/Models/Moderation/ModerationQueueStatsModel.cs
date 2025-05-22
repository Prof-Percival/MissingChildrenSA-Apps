namespace MissingChildrenSA.Models.Moderation;

public sealed class ModerationQueueStatsModel(
    ModerationQueueStatsResponseModel stats)
{
    public int Unmoderated { get; } = stats.Unmoderated;
    public int InModeration { get; } = stats.InModeration;
    public int Failed { get; } = stats.Failed;
    public int Approved { get; } = stats.Approved;
}