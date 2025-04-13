using MCSA_API.Domain;
using MCSA_API.Domain.MissingPersons;
using MCSA_API.Domain.Moderation;

namespace MCSA_API.Models.MissingPersons;

public sealed class GetMissingPersonResponse
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public DateTime DateOfBirth { get; init; }
    public Gender Gender { get; init; }
    public Race Race { get; init; }
    public Province Province { get; init; }
    public DateTime DateWentMissing { get; init; }
    public string HairColour { get; init; }
    public string HairLengthOrStyle { get; init; }
    public string EyeColour { get; init; }
    public int Height { get; init; }
    public double Weight { get; init; }
    public string MarksTattoos { get; init; }
    public string LastSeenWearing { get; init; }
    public string LocationLastSeen { get; init; }
    public string DetailsOfDisappearance { get; init; }
    public string ImageUrl { get; init; }
    public string PoliceStation { get; init; }
    public string CaseNumber { get; init; }
    public string InvestigatingOfficer { get; init; }
    public string InvestigatingOfficerContactNumber { get; init; }
    public string FamilyContactName { get; init; }
    public string FamilyContactNumber { get; init; }
    public MissingPersonStatus Status { get; init; }
    public DateTime Created { get; init; }
    public DateTime Updated { get; init; }
    public ModerationStatus ModerationStatus { get; init; }
    public int? LastEditedByUserId { get; init; }

    public GetMissingPersonResponse(MissingPerson missingPerson)
    {
        Id = missingPerson.Id.Value;
        FirstName = missingPerson.FirstName;
        LastName = missingPerson.LastName;
        DateOfBirth = missingPerson.DateOfBirth;
        Gender = missingPerson.Gender;
        Race = missingPerson.Race;
        Province = missingPerson.Province;
        DateWentMissing = missingPerson.DateWentMissing;
        HairColour = missingPerson.HairColour;
        HairLengthOrStyle = missingPerson.HairLengthOrStyle;
        EyeColour = missingPerson.EyeColour;
        Height = missingPerson.Height;
        Weight = missingPerson.Weight;
        MarksTattoos = missingPerson.MarksTattoos;
        LastSeenWearing = missingPerson.LastSeenWearing;
        LocationLastSeen = missingPerson.LocationLastSeen;
        DetailsOfDisappearance = missingPerson.DetailsOfDisappearance;
        ImageUrl = missingPerson.ImageUrl;
        PoliceStation = missingPerson.PoliceStation;
        CaseNumber = missingPerson.CaseNumber;
        InvestigatingOfficer = missingPerson.InvestigatingOfficer;
        InvestigatingOfficerContactNumber = missingPerson.InvestigatingOfficerContactNumber;
        FamilyContactName = missingPerson.FamilyContactName;
        FamilyContactNumber = missingPerson.FamilyContactNumber;
        Status = missingPerson.Status;
        Created = missingPerson.Created;
        Updated = missingPerson.Updated;
        ModerationStatus = missingPerson.ModerationStatus;
        LastEditedByUserId = missingPerson.LastEditedByUserId;
    }
}