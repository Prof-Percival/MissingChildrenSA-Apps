namespace MissingChildrenSA.Services.Auth;

public static class AuthService
{
    private static string _token;
    private static DateTime _tokenExpiry;
    private static Principal _principal;

    public static bool IsAuthenticated => _principal != null && !string.IsNullOrWhiteSpace(_principal.Token);
    public static string Token => GetToken();
    public static string Role => GetRole();

    public static bool SetPrincipal(Principal principal)
    {
        if (principal == null)
        {
            _principal = principal;

            return true;
        }

        return false;
    }

    public static Principal GetPrincipal()
    {
        return _principal;
    }

    // Get the token if it's still valid, else return null
    private static string GetToken()
    {
        var principal = GetPrincipal();

        if (principal == null ||
            string.IsNullOrWhiteSpace(principal.Token) ||
            IsTokenExpired())
        {
            // Token is either not set or expired, log out the user
            Logout();

            return null;
        }

        return principal.Token;
    }

    // Get the current user's role if token it's still valid, else return null
    private static string GetRole()
    {
        var principal = GetPrincipal();

        if (principal == null ||
            string.IsNullOrWhiteSpace(principal.Token) ||
            string.IsNullOrWhiteSpace(principal.Role) ||
            IsTokenExpired())
        {
            // Token is either not set or expired, log out the user
            Logout();

            return null;
        }

        return principal.Role;
    }

    // Check if the token is expired
    private static bool IsTokenExpired()
    {
        return DateTime.Now >= GetPrincipal()?.TokenExpiry;
    }

    /*
    // Log out the user by clearing the token and forcing them to log in again
    public static void Logout()
    {
        _token = null;
        _tokenExpiry = DateTime.MinValue;
        // Redirect to login screen
        Application.OpenForms["LoginForm"]?.Show();
        Application.OpenForms["MainForm"]?.Close(); // Close the main form if it's open
    }*/

    public static void Logout()
    {
        _principal = null;
    }
}

public sealed class Principal
{
    public string Token { get; init; }
    public string Role { get; init; }
    public DateTime TokenExpiry { get; init; }
}