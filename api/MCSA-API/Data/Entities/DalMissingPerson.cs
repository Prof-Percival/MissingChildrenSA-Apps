using MCSA_API.Domain.MissingPersons;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCSA_API.Data.Entities;

[Table("MissingPerson")]
public class DalMissingPerson
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]

    public string FirstName { get; set; }

    [Required]
    [MaxLength(150)]
    public string LastName { get; set; }

    [Required]
    public DateTime DateOfBirth { get; set; }

    [Required]
    [MaxLength(50)]
    public string Gender { get; set; }

    [Required]
    [MaxLength(20)]
    public string Race { get; set; }

    [Required]
    [MaxLength(20)]
    public string Province { get; set; }

    [Required]
    public DateTime DateWentMissing { get; set; }

    [Required]
    [MaxLength(50)]
    public string HairColour { get; set; }

    [Required]
    [MaxLength(50)]
    public string HairLengthOrStyle { get; set; }

    [Required]
    [MaxLength(50)]
    public string EyeColour { get; set; }

    [Required]
    public int Height { get; set; }

    [Required]
    public double Weight { get; set; }

    [Required]
    [MaxLength(100)]
    public string MarksTattoos { get; set; }

    [Required]
    [MaxLength(500)]
    public string LastSeenWearing { get; set; }

    [Required]
    [MaxLength(150)]
    public string LocationLastSeen { get; set; }

    [Required]
    [MaxLength(500)]
    public string DetailsOfDisappearance { get; set; }

    [Required]
    [MaxLength(500)]
    public string ImageUrl { get; set; }

    [Required]
    [MaxLength(250)]
    public string PoliceStation { get; set; }

    [Required]
    [MaxLength(50)]
    public string CaseNumber { get; set; }

    [Required]
    [MaxLength(300)]
    public string InvestigatingOfficer { get; set; }

    [Required]
    [MaxLength(15)]
    public string InvestigatingOfficerContactNumber { get; set; }

    [Required]
    [MaxLength(300)]
    public string FamilyContactName { get; set; }

    [Required]
    [MaxLength(15)]
    public string FamilyContactNumber { get; set; }

    [Required]
    [MaxLength(100)]
    public MissingPersonStatus StatusId { get; set; }

    [Required]
    public DateTime Created { get; set; }

    [Required]
    public DateTime Updated { get; set; }

    [Required]
    public int ModerationStatusId { get; set; }

    public int? LastEditedByUserId { get; set; }

    public DalUser LastEditedByUser { get; set; }
}