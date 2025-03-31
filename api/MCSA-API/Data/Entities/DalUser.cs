using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCSA_API.Data.Entities;

[Table("User")]
public class DalUser
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(255)]
    public string Username { get; set; }

    [Required]
    [MaxLength(256)]
    public string PasswordHash { get; set; }

    [Required]
    [MaxLength(150)]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(150)]
    public string LastName { get; set; }

    [Required]
    public int RoleId { get; set; }

    [Required]
    public DateTime Created { get; set; }

    [Required]
    public DateTime Updated { get; set; }
}