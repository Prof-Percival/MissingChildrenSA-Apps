using System.ComponentModel.DataAnnotations;

namespace MCSA_API.Models.Auth;

public sealed class AuthenticateRequest
{
    [Required]
    [EmailAddress]
    public string Username { get; init; }

    [Required]
    public string Password { get; init; }
}