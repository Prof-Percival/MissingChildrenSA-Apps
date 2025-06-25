using MCSA_API.Domain.Users;
using MCSA_API.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace MCSA_API.Models.Users;

public sealed class CreateUserRequest : Person
{
    [Required]
    [EmailAddress]
    public string Username { get; init; }

    [Required]
    public string Password { get; init; }

    [Required]
    [Display(Name = "User Role")]
    public UserRole? UserRole { get; init; }
}