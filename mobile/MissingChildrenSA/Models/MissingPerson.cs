using System.ComponentModel.DataAnnotations;

namespace MissingChildrenSA.Models;

public class MissingPerson
{
    public int Id { get; set; }

    [Required(ErrorMessage = "First name is required")]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "Date of birth is required")]
    [Display(Name = "Date of Birth")]
    public DateTime? DateOfBirth { get; set; }

    [Required(ErrorMessage = "Gender is required")]
    [Display(Name = "Gender")]
    public string Gender { get; set; }

    [Required(ErrorMessage = "Race is required")]
    [Display(Name = "Race")]
    public string Race { get; set; }

    [Required(ErrorMessage = "Province is required")]
    [Display(Name = "Province")]
    public string Province { get; set; }

    public DateTime MissingDate { get; set; } = DateTime.Today;
    public TimeSpan MissingTime { get; set; } = DateTime.Now.TimeOfDay;

    public DateTime DateWentMissing => new(
        MissingDate.Year,
        MissingDate.Month,
        MissingDate.Day,
        MissingTime.Hours,
        MissingTime.Minutes,
        0
    );

    [Required(ErrorMessage = "Hair colour is required")]
    [Display(Name = "Hair Colour")]
    public string HairColour { get; set; }

    [Required(ErrorMessage = "Hair length or style is required")]
    [Display(Name = "Hair Length / Style")]
    public string HairLengthOrStyle { get; set; }

    [Required(ErrorMessage = "Eye colour is required")]
    [Display(Name = "Eye Colour")]
    public string EyeColour { get; set; }

    [Required(ErrorMessage = "Height is required")]
    [Display(Name = "Height (cm)")]
    [Range(30, 300, ErrorMessage = "Height must be between 30cm and 300cm")]
    public int? Height { get; set; }

    [Required(ErrorMessage = "Weight is required")]
    [Display(Name = "Weight (kg)")]
    [Range(3, 500, ErrorMessage = "Weight must be between 3kg and 500kg")]
    public double? Weight { get; set; }

    [Display(Name = "Marks or Tattoos")]
    public string MarksTattoos { get; set; }

    [Display(Name = "Last Seen Wearing")]
    public string LastSeenWearing { get; set; }

    [Display(Name = "Location Last Seen")]
    public string LocationLastSeen { get; set; }

    [Required(ErrorMessage = "Image URL is required")]
    [Display(Name = "Image URL")]
    public string ImageUrl { get; set; }

    [Required(ErrorMessage = "Police station is required")]
    [Display(Name = "Police Station")]
    public string PoliceStation { get; set; }

    [Required(ErrorMessage = "Case number is required")]
    [Display(Name = "Case Number")]
    public string CaseNumber { get; set; }

    [Required(ErrorMessage = "Investigating officer is required")]
    [Display(Name = "Investigating Officer")]
    public string InvestigatingOfficer { get; set; }

    [Required(ErrorMessage = "Officer contact number is required")]
    [Display(Name = "Officer Contact Number")]
    [Phone(ErrorMessage = "Enter a valid phone number")]
    public string InvestigatingOfficerContactNumber { get; set; }

    [Display(Name = "Family Contact Name")]
    public string FamilyContactName { get; set; }

    [Display(Name = "Family Contact Number")]
    [Phone(ErrorMessage = "Enter a valid phone number")]
    public string FamilyContactNumber { get; set; }
}