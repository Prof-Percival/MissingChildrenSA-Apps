using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Models.Users;
using MissingChildrenSA.Services.Users;

namespace MissingChildrenSA.Forms;

public partial class DashboardForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly CurrentUserService _currentUserService;

    private CurrentUser _currentUser;

    public DashboardForm(
        EnumLoader enumLoader,
        CurrentUserService currentUserService)
    {
        InitializeComponent();
        _enumLoader = enumLoader;
        _currentUserService = currentUserService;
    }

    private async void DashboardForm_Load(object sender, EventArgs e)
    {
        MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        WindowState = FormWindowState.Maximized;

        _currentUser = await _currentUserService.GetCurrentUser();

        await _enumLoader.LoadEnumsAsync();

        PopulateUserProfile();
    }

    private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        //Shutdown Application when Dashboard closes
        Application.Exit();
    }

    private void PopulateUserProfile()
    {
        LblUserName.Text = _currentUser.FullName;
    }
}