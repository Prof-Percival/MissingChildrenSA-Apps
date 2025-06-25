using MCSA_API.Domain.Moderation.Stats;

namespace MCSA_API.Models.Moderation.Stats;

public sealed class ModerationQueueStatsResponseModel(
    ModerationQueueStats stats)
{
    public int Unmoderated { get; } = stats.Unmoderated;
    public int InModeration { get; } = stats.InModeration;
    public int Failed { get; } = stats.Failed;
    public int Approved { get; } = stats.Approved;
}