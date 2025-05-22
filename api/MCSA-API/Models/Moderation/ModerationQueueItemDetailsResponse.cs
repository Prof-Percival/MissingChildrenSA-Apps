using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;
using MCSA_API.Models.MissingPersons;

namespace MCSA_API.Models.Moderation;

public sealed class ModerationQueueItemDetailsResponse
{
    public int QueueId { get; init; }
    public ModerationStatus ModerationStatus { get; init; }
    public string ModerationStatusReason { get; init; }
    public DateTime Created { get; init; }
    public DateTime Updated { get; init; }
    public int? ModeratedByUserId { get; init; }
    public MissingPersonViewModel MissingPerson { get; init; }

    public ModerationQueueItemDetailsResponse(
        MissingPersonModerationQueue queue,
        MissingPerson missingPerson)
    {
        QueueId = queue.Id.Value;
        ModerationStatus = queue.ModerationStatus;
        ModerationStatusReason = queue.ModerationStatusReason;
        Created = queue.Created;
        Updated = queue.Updated;
        ModeratedByUserId = queue.ModeratedByUserId;
        MissingPerson = new MissingPersonViewModel(missingPerson);
    }
}