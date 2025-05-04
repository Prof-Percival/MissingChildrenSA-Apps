using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Forms;
using MissingChildrenSA.Forms.Auth;
using MissingChildrenSA.Services.Auth;

namespace MissingChildrenSA;

public partial class MainForm : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ITokenProvider _tokenProvider;

    public MainForm(
        IServiceProvider serviceProvider,
        ITokenProvider tokenProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
        _tokenProvider = tokenProvider;
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        using var loginForm = _serviceProvider.GetRequiredService<LoginForm>();
        var dashboardForm = _serviceProvider.GetRequiredService<DashboardForm>();

        loginForm.ShowDialog();

        //Login Form Closed when we get to this point

        //If User logged in, hide this form
        if (_tokenProvider.IsAuthenticated)
        {
            Hide();

            dashboardForm.Show();
        }
    }
}
