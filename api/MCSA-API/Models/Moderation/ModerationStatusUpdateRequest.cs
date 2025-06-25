using MCSA_API.Domain.Moderation;
using System.ComponentModel.DataAnnotations;

namespace MCSA_API.Models.Moderation;

public class ModerationStatusUpdateRequest
{
    [Required, Display(Name = "Queue Item Id")]
    public int? QueueItemId { get; set; }

    [Required]
    public ModerationStatus Status { get; set; }

    public string Reason { get; set; }
}