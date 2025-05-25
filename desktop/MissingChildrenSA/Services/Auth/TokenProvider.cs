namespace MissingChildrenSA.Services.Auth;

public sealed class TokenProvider : ITokenProvider
{
    private Principal _principal;

    public bool IsAuthenticated =>
        _principal != null && !string.IsNullOrWhiteSpace(_principal.Token) && !IsTokenExpired();

    public string Token => GetToken();
    public string Role => GetRole();

    public bool SetPrincipal(Principal principal)
    {
        if (_principal == null)
        {
            _principal = principal;

            return true;
        }

        return false;
    }

    public Principal GetPrincipal()
    {
        return _principal;
    }

    public void Logout()
    {
        _principal = null;
    }

    public bool IsSuperUser() => IsAuthenticated && Role == Constants.SuperUser;
    public bool IsOperationalSupport() => IsAuthenticated && Role == Constants.OperationalSupport;
    public bool IsReceptionist() => IsAuthenticated && Role == Constants.Receptionist;

    private string GetToken()
    {
        if (_principal == null ||
            string.IsNullOrWhiteSpace(_principal.Token) ||
            IsTokenExpired())
        {
            Logout();

            return null;
        }

        return _principal.Token;
    }

    private string GetRole()
    {
        if (_principal == null ||
            string.IsNullOrWhiteSpace(_principal.Role) ||
            IsTokenExpired())
        {
            Logout();
            return null;
        }

        return _principal.Role;
    }

    private bool IsTokenExpired()
    {
        return _principal != null && DateTime.Now >= _principal.TokenExpiry;
    }
}

public sealed class Principal
{
    public string Token { get; init; }
    public string Role { get; init; }
    public DateTime TokenExpiry { get; init; }
}