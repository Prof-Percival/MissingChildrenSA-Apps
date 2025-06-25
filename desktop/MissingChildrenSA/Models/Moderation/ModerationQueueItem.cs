namespace MissingChildrenSA.Models.Moderation;

public class ModerationQueueItem(ModerationQueueItemResponse queue)
{
    public int Id { get; init; } = queue.Id;
    public string Created { get; init; } = queue.Created;
    public string Updated { get; init; } = queue.Updated;
    public int? ModeratedByUserId { get; init; } = queue.ModeratedByUserId;
    public int MissingPersonId { get; init; } = queue.MissingPersonId;
    public string ModerationStatus { get; init; } = queue.ModerationStatus;
    public string ModerationStatusReason { get; init; } = queue.ModerationStatusReason;
}