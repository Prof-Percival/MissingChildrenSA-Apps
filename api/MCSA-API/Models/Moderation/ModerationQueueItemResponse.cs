using MCSA_API.Domain.Moderation;
using MCSA_API.Helpers;

namespace MCSA_API.Models.Moderation;

public class ModerationQueueItemResponse
{
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public int? ModeratedByUserId { get; set; }
    public int MissingPersonId { get; set; }
    public string ModerationStatus { get; set; }
    public string ModerationStatusReason { get; set; }

    public ModerationQueueItemResponse(MissingPersonModerationQueue queue)
    {
        Id = queue.Id.Value;
        Created = queue.Created;
        Updated = queue.Updated;
        ModeratedByUserId = queue.ModeratedByUserId;
        MissingPersonId = queue.MissingPersonId;
        ModerationStatus = queue.ModerationStatus.GetBestDescription();
        ModerationStatusReason = queue.ModerationStatusReason;
    }
}