using MissingChildrenSA.Services.Auth;

namespace MissingChildrenSA.Forms.Auth;

public partial class LoginForm : Form
{
    private readonly ApiClient _apiClient;
    private readonly ITokenProvider _tokenProvider;

    public LoginForm(
        ApiClient apiClient,
        ITokenProvider tokenProvider)
    {
        InitializeComponent();
        _apiClient = apiClient;
        _tokenProvider = tokenProvider;
    }

    private async void BtnLogin_Click(object sender, EventArgs e)
    {
        // Read username and password from form fields
        var username = TxtUsername.Text;
        var password = TxtPassword.Text;

        // Validate input
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            LblError.Text = "Username and password are required!";

            return;
        }

        // Send login request to the API
        var authResponse = await AuthenticateUserAsync(username, password);

        if (authResponse != null)
        {
            // Save JWT token for subsequent requests
            _tokenProvider.SetPrincipal(new Principal
            {
                Token = authResponse.Token,
                Role = authResponse.Role,
                TokenExpiry = authResponse.TokenExpiry.DateTime
            });

            // Hide MainForm, LoginForm and Navigate to the Dashboard
            Close();
        }
        else
        {
            LblError.Text = "Invalid username or password!";
        }
    }

    private async Task<AuthenticateResponse> AuthenticateUserAsync(string username, string password)
    {
        var authRequest = new AuthenticateRequest
        {
            Username = username,
            Password = password
        };
        try
        {
            return await _apiClient.AuthenticateAsync(authRequest);
        }
        catch (ApiException)
        {
            //Uncomment on Debug
            //MessageBox.Show($"{ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return null;
    }

    private void BtnLogin_MouseHover(object sender, EventArgs e)
    {
        BtnLogin.ForeColor = Color.FromArgb(237, 31, 39);
        BtnLogin.BackColor = Color.White;
    }

    private void BtnLogin_MouseLeave(object sender, EventArgs e)
    {
        BtnLogin.ForeColor = Color.White;
        BtnLogin.BackColor = Color.FromArgb(237, 31, 39);
    }
}