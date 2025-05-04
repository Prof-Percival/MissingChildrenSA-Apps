using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Forms.Auth;

namespace MissingChildrenSA;

public partial class MainForm : Form
{
    private readonly IServiceProvider _serviceProvider;

    public MainForm(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    private void BtnLogin_Click(object sender, EventArgs e)
    {
        using var loginForm = _serviceProvider.GetRequiredService<LoginForm>();

        loginForm.ShowDialog();
    }
}
