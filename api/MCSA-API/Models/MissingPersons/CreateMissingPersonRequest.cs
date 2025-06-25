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
    [Display(Name = "Date Went Missing")]
    public DateTimeOffset? DateWentMissing { get; set; }

    [Required]
    [Display(Name = "Hair Colour")]
    public string HairColour { get; set; }

    [Required]
    [Display(Name = "Hair Length Or Style")]
    public string HairLengthOrStyle { get; set; }

    [Required]
    [Display(Name = "Eye Colour")]
    public string EyeColour { get; set; }

    [Required]
    public int? Height { get; set; }

    [Required]
    public double? Weight { get; set; }

    [Required]
    [Display(Name = "Marks / Tattoes")]
    public string MarksTattoos { get; set; }

    [Required]
    [Display(Name = "Last Seen Wearing")]
    public string LastSeenWearing { get; set; }

    [Required]
    [Display(Name = "Location Last Seen")]
    public string LocationLastSeen { get; set; }

    [Required]
    [Display(Name = "Image Url")]
    public string ImageUrl { get; set; }

    [Required]
    [Display(Name = "Police Station")]
    public string PoliceStation { get; set; }

    [Required]
    [Display(Name = "Case Number")]
    public string CaseNumber { get; set; }

    [Required]
    [Display(Name = "Investigating Officer")]
    public string InvestigatingOfficer { get; set; }

    [Required]
    [Display(Name = "Investigating Officer Contact Number")]
    public string InvestigatingOfficerContactNumber { get; set; }

    [Required]
    [Display(Name = "Family Contact Name")]
    public string FamilyContactName { get; set; }

    [Required]
    [Display(Name = "Family Contact Number")]
    public string FamilyContactNumber { get; set; }
}