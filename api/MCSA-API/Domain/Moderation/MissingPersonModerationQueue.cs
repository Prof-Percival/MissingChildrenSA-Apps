using MCSA_API.Data.Entities;

namespace MCSA_API.Domain.Moderation;

public sealed class MissingPersonModerationQueue
{
    public int? Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public int? ModeratedByUserId { get; private set; }
    public ModerationStatus ModerationStatus { get; private set; }
    public string ModerationStatusReason { get; private set; }
    public int MissingPersonId { get; set; }
    public bool IsNew => !Id.HasValue;

    public MissingPersonModerationQueue() { }

    public MissingPersonModerationQueue(DalMissingPersonModerationQueue queue)
    {
        Id = queue.Id;
        Created = queue.Created;
        Updated = queue.Updated;
        ModeratedByUserId = queue.ModeratedByUserId;
        ModerationStatus = (ModerationStatus)queue.ModerationStatusId;
        ModerationStatusReason = queue.ModerationStatusReason;
        MissingPersonId = queue.MissingPersonId;
    }

    internal void SetUnmoderated()
    {
        ModerationStatus = ModerationStatus.Unmoderated;
        ModeratedByUserId = null;
        ModerationStatusReason = null;
    }

    internal bool TryStartModeration(int moderatedByUserId, out string errorMessage)
    {
        if (ModeratedByUserId.HasValue)
        {
            errorMessage = "Moderation already started";

            return false;
        }

        ModerationStatus = ModerationStatus.InModeration;
        ModeratedByUserId = moderatedByUserId;
        ModerationStatusReason = null;

        errorMessage = null;

        return true;
    }

    internal bool TryFailModeration(string reason, out string errorMessage)
    {
        if (string.IsNullOrWhiteSpace(reason))
        {
            errorMessage = "Moderation Reason is required when failing item for moderation.";

            return false;
        }

        ModerationStatus = ModerationStatus.Failed;
        ModerationStatusReason = reason;

        errorMessage = null;
        return true;
    }

    internal void Approve()
    {
        ModerationStatus = ModerationStatus.Approved;
    }
}