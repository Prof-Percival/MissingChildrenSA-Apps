namespace MissingChildrenSA.Services.Auth;

public interface ITokenProvider
{
    bool IsAuthenticated { get; }
    string Token { get; }
    string Role { get; }
    Principal GetPrincipal();
    bool SetPrincipal(Principal principal);
    void Logout();
}