using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCSA_API.Data.Entities;

[Table("MissingPersonModerationQueue")]
public class DalMissingPersonModerationQueue
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public DateTime Created { get; set; }

    [Required]
    public DateTime Updated { get; set; }

    public int? ModeratedByUserId { get; set; }

    [Required]
    public int ModerationStatusId { get; set; }

    [MaxLength(255)]
    public string ModerationStatusReason { get; set; }

    [Required]
    public int MissingPersonId { get; set; }

    public DalUser ModeratedByUser { get; set; }
    public DalMissingPerson MissingPerson { get; set; }
}