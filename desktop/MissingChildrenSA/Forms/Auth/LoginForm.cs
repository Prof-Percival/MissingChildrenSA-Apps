using MissingChildrenSA.Models.Auth;
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
        var loginResponse = await AuthenticateUserAsync(username, password);

        if (loginResponse != null)
        {
            // Save JWT token for subsequent requests
            _tokenProvider.SetPrincipal(new Principal
            {
                Token = loginResponse.Token,
                Role = loginResponse.Role,
                TokenExpiry = DateTime.Now.AddHours(3)
            });

            // Store username and role (for checking user permissions)
            //Properties.Settings.Default.Username = username;
            //Properties.Settings.Default.UserRole = loginResponse.Role;
            //Properties.Settings.Default.Save();

            // Hide MainForm, LoginForm and Navigate to the Dashboard
            Close();

            //var dashboardForm = new DashboardForm();
            //dashboardForm.Show();
        }
        else
        {
            LblError.Text = "Invalid username or password!";
        }
    }

    private async Task<LoginResponse> AuthenticateUserAsync(string username, string password)
    {
        var authRequest = new AuthenticateRequest
        {
            Username = username,
            Password = password
        };
        try
        {
            var response = await _apiClient.AuthenticateAsync(authRequest);

            return new LoginResponse
            {
                Token = response.Token
            };
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