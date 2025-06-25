using MCSA_API.Domain.MissingPersons;
using MCSA_API.Helpers;

namespace MCSA_API.Models.MissingPersons;

public sealed class MissingPersonViewModel
{
    public int Id { get; init; }
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public string DateOfBirth { get; init; }
    public string Gender { get; init; }
    public string Race { get; init; }
    public string Province { get; init; }
    public string DateWentMissing { get; init; }
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
    public string Status { get; init; }
    public string Created { get; init; }
    public string Updated { get; init; }
    public string ModerationStatus { get; init; }
    public int? LastEditedByUserId { get; init; }

    public MissingPersonViewModel(MissingPerson missingPerson)
    {
        Id = missingPerson.Id.Value;
        FirstName = missingPerson.FirstName;
        LastName = missingPerson.LastName;
        DateOfBirth = FormattingHelper.FormatDate(missingPerson.DateOfBirth);
        Gender = missingPerson.Gender.GetBestDescription();
        Race = missingPerson.Race.GetBestDescription();
        Province = missingPerson.Province.GetBestDescription();
        DateWentMissing = FormattingHelper.FormatDateTime(missingPerson.DateWentMissing);
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
        Status = missingPerson.Status.GetBestDescription();
        Created = FormattingHelper.FormatDateTime(missingPerson.Created);
        Updated = FormattingHelper.FormatDateTime(missingPerson.Updated);
        ModerationStatus = missingPerson.ModerationStatus.GetBestDescription();
        LastEditedByUserId = missingPerson.LastEditedByUserId;
    }
}