using MCSA_API.Domain.MissingPersons;
using MCSA_API.Helpers;

namespace MCSA_API.Models.MissingPersons;

public sealed class CreateMissingPersonResponse
{
    public int Id { get; }
    public string Status { get; }
    public string ModerationStatus { get; }

    public CreateMissingPersonResponse(MissingPerson missingPerson)
    {
        Id = missingPerson.Id.Value;
        Status = missingPerson.Status.GetBestDescription();
        ModerationStatus = missingPerson.ModerationStatus.GetBestDescription();
    }
}