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
        LblUserRole.Text = _currentUser.UserRole;
    }

    private void LblHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenLink(Constants.McsaBaseUrl, fullUrl: true);
    }

    private void LblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenLink("who-we-are/");
    }

    private void LblGetInvolved_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenLink("get-involved/");
    }

    private void LblChildSafety_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenLink("child-safety/");
    }

    private void LblContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        OpenLink("contact/");
    }

    private void BtnDonate_Click(object sender, EventArgs e)
    {
        OpenLink("donate/");
    }

    private static void OpenLink(string pathOrUrl, bool fullUrl = false)
    {
        try
        {
            var url = fullUrl ? pathOrUrl : $"{Constants.McsaBaseUrl}/{pathOrUrl}";

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Unable to open link: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}