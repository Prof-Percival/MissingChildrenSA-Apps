using System.ComponentModel.DataAnnotations;

namespace MCSA_API.Models.Shared;

public abstract class Person
{
    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }
}