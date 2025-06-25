using System.ComponentModel;

namespace MCSA_API.Domain.Moderation;

public enum ModerationStatus
{
    [Description("Unmoderated")]
    Unmoderated = 1,

    [Description("In Moderation")]
    InModeration,

    [Description("Failed")]
    Failed,

    [Description("Approved")]
    Approved
}