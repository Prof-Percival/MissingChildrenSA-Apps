namespace MCSA_API.Models.Auth;

public sealed class AuthenticateResponse
{
    public string Token { get; init; }
    public string Role { get; init; }
    public DateTime TokenExpiry { get; init; }
}