namespace MCSA_API.Domain.Moderation;

public sealed class MissingPersonModerationQueue
{
    public int? Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public int? ModeratedByUserId { get; set; }
    public ModerationStatus ModerationStatus { get; set; }
    public string ModerationStatusReason { get; set; }
    public int MissingPersonId { get; set; }
    public bool IsNew => !Id.HasValue;
}