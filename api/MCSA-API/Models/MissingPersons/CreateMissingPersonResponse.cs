using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;

namespace MCSA_API.Models.MissingPersons;

public sealed class CreateMissingPersonResponse
{
    public int Id { get; init; }
    public MissingPersonStatus Status { get; init; }
    public ModerationStatus ModerationStatus { get; init; }

    public CreateMissingPersonResponse(MissingPerson missingPerson)
    {
        Id = missingPerson.Id.Value;
        Status = missingPerson.Status;
        ModerationStatus = missingPerson.ModerationStatus;
    }
}