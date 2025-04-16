using MCSA_API.Domain.MissingPersons;
using MCSA_API.Helpers;

namespace MCSA_API.Models.MissingPersons;

public sealed class CreateMissingPersonResponse
{
    public int Id { get; init; }
    public string Status { get; init; }
    public string ModerationStatus { get; init; }

    public CreateMissingPersonResponse(MissingPerson missingPerson)
    {
        Id = missingPerson.Id.Value;
        Status = missingPerson.Status.GetBestDescription();
        ModerationStatus = missingPerson.ModerationStatus.GetBestDescription();
    }
}