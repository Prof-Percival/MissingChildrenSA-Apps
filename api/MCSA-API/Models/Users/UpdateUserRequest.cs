using MCSA_API.Domain.Users;
using MCSA_API.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace MCSA_API.Models.Users;

public sealed class UpdateUserRequest : Person
{
    [Required]
    [Display(Name = "User Role")]
    public UserRole? UserRole { get; init; }

    public string Password { get; init; }
}