using MCSA_API.Domain;
using MCSA_API.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace MCSA_API.Models.MissingPersons;

public class CreateMissingPersonRequest : Person
{

    [Required, Display(Name = "Date of Birth")]
    public DateTimeOffset? DateOfBirth { get; set; }

    [Required]
    public Gender? Gender { get; set; }

    [Required]
    public Race? Race { get; set; }

    [Required]
    public Province? Province { get; set; }

    [Required]
    public DateTimeOffset? DateWentMissing { get; set; }

    [Required]
    public string HairColour { get; set; }

    [Required]
    public string HairLengthOrStyle { get; set; }

    [Required]
    public string EyeColour { get; set; }

    [Required]
    public int? Height { get; set; }

    [Required]
    public double? Weight { get; set; }

    public string MarksTattoos { get; set; }
    public string LastSeenWearing { get; set; }
    public string LocationLastSeen { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    [Required]
    public string PoliceStation { get; set; }

    [Required]
    public string CaseNumber { get; set; }

    [Required]
    public string InvestigatingOfficer { get; set; }

    [Required]
    public string InvestigatingOfficerContactNumber { get; set; }

    public string FamilyContactName { get; set; }
    public string FamilyContactNumber { get; set; }
}