namespace MissingChildrenSA.Models.MissingPersons;

public sealed class MissingPersonModel(MissingPersonViewModel missingPerson)
{
    public int Id { get; init; } = missingPerson.Id;
    public string FirstName { get; init; } = missingPerson.FirstName;
    public string LastName { get; init; } = missingPerson.LastName;
    public string DateOfBirth { get; init; } = missingPerson.DateOfBirth;
    public string Gender { get; init; } = missingPerson.Gender;
    public string Race { get; init; } = missingPerson.Race;
    public string Province { get; init; } = missingPerson.Province;
    public string DateWentMissing { get; init; } = missingPerson.DateWentMissing;
    public string HairColour { get; init; } = missingPerson.HairColour;
    public string HairLengthOrStyle { get; init; } = missingPerson.HairLengthOrStyle;
    public string EyeColour { get; init; } = missingPerson.EyeColour;
    public int Height { get; init; } = missingPerson.Height;
    public double Weight { get; init; } = missingPerson.Weight;
    public string MarksTattoos { get; init; } = missingPerson.MarksTattoos;
    public string LastSeenWearing { get; init; } = missingPerson.LastSeenWearing;
    public string LocationLastSeen { get; init; } = missingPerson.LocationLastSeen;
    public string DetailsOfDisappearance { get; init; } = missingPerson.DetailsOfDisappearance;
    public string ImageUrl { get; init; } = missingPerson.ImageUrl;
    public string PoliceStation { get; init; } = missingPerson.PoliceStation;
    public string CaseNumber { get; init; } = missingPerson.CaseNumber;
    public string InvestigatingOfficer { get; init; } = missingPerson.InvestigatingOfficer;
    public string InvestigatingOfficerContactNumber { get; init; } = missingPerson.InvestigatingOfficerContactNumber;
    public string FamilyContactName { get; init; } = missingPerson.FamilyContactName;
    public string FamilyContactNumber { get; init; } = missingPerson.FamilyContactNumber;
    public string Status { get; init; } = missingPerson.Status;
    public string Created { get; init; } = missingPerson.Created;
    public string Updated { get; init; } = missingPerson.Updated;
    public string ModerationStatus { get; init; } = missingPerson.ModerationStatus;
    public int? LastEditedByUserId { get; init; } = missingPerson.LastEditedByUserId;
}