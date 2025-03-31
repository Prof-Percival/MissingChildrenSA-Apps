using MCSA_API.Data.Entities;
using MCSA_API.Domain.Moderation;

namespace MCSA_API.Domain.MissingPersons;

public class MissingPerson
{
    public int? Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Race { get; set; }
    public string Province { get; set; }
    public DateTime DateWentMissing { get; set; }
    public string HairColour { get; set; }
    public string HairLengthOrStyle { get; set; }
    public string EyeColour { get; set; }
    public int Height { get; set; }
    public double Weight { get; set; }
    public string MarksTattoos { get; set; }
    public string LastSeenWearing { get; set; }
    public string LocationLastSeen { get; set; }
    public string DetailsOfDisappearance { get; set; }
    public string ImageUrl { get; set; }
    public string PoliceStation { get; set; }
    public string CaseNumber { get; set; }
    public string InvestigatingOfficer { get; set; }
    public string InvestigatingOfficerContactNumber { get; set; }
    public string FamilyContactName { get; set; }
    public string FamilyContactNumber { get; set; }
    public MissingPersonStatus Status { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }
    public ModerationStatus ModerationStatus { get; set; }
    public int? LastEditedByUserId { get; set; }

    public bool IsNew => !Id.HasValue;

    public MissingPerson() { }

    public MissingPerson(DalMissingPerson dalMissingPerson)
    {
        Id = dalMissingPerson.Id;
        FirstName = dalMissingPerson.FirstName;
        LastName = dalMissingPerson.LastName;
        DateOfBirth = dalMissingPerson.DateOfBirth;
        Gender = dalMissingPerson.Gender;
        Race = dalMissingPerson.Race;
        Province = dalMissingPerson.Province;
        DateWentMissing = dalMissingPerson.DateWentMissing;
        HairColour = dalMissingPerson.HairColour;
        HairLengthOrStyle = dalMissingPerson.HairLengthOrStyle;
        EyeColour = dalMissingPerson.EyeColour;
        Height = dalMissingPerson.Height;
        Weight = dalMissingPerson.Weight;
        MarksTattoos = dalMissingPerson.MarksTattoos;
        LastSeenWearing = dalMissingPerson.LastSeenWearing;
        LocationLastSeen = dalMissingPerson.LocationLastSeen;
        DetailsOfDisappearance = dalMissingPerson.DetailsOfDisappearance;
        ImageUrl = dalMissingPerson.ImageUrl;
        PoliceStation = dalMissingPerson.PoliceStation;
        CaseNumber = dalMissingPerson.CaseNumber;
        InvestigatingOfficer = dalMissingPerson.InvestigatingOfficer;
        InvestigatingOfficerContactNumber = dalMissingPerson.InvestigatingOfficerContactNumber;
        FamilyContactName = dalMissingPerson.FamilyContactName;
        FamilyContactNumber = dalMissingPerson.FamilyContactNumber;
        Status = (MissingPersonStatus)dalMissingPerson.StatusId;
        Created = dalMissingPerson.Created;
        Updated = dalMissingPerson.Updated;
        ModerationStatus = (ModerationStatus)dalMissingPerson.ModerationStatusId;
        LastEditedByUserId = dalMissingPerson.LastEditedByUserId;
    }
}