using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Forms.MissingPersons;
using MissingChildrenSA.Forms.Moderation;
using MissingChildrenSA.Forms.Users;
using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Models.Users;
using MissingChildrenSA.Services.Auth;
using MissingChildrenSA.Services.Users;

namespace MissingChildrenSA.Forms;

public partial class DashboardForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly CurrentUserService _currentUserService;
    private readonly ITokenProvider _tokenProvider;
    private readonly IServiceProvider _serviceProvider;

    private CurrentUser _currentUser;

    public DashboardForm(
        EnumLoader enumLoader,
        CurrentUserService currentUserService,
        ITokenProvider tokenProvider,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _enumLoader = enumLoader;
        _currentUserService = currentUserService;
        _tokenProvider = tokenProvider;
        _serviceProvider = serviceProvider;
    }

    private async void DashboardForm_Load(object sender, EventArgs e)
    {
        HideMenusBasedOnPermissions();

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
        LblUserRole.Text = $"[ {_currentUser.UserRole} ]";
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

    private void PicLogout_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show("Are You Sure You Want To Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.Yes)
        {
            var mainForm = _serviceProvider.GetRequiredService<MainForm>();

            _tokenProvider.Logout();

            Hide();

            mainForm.Show();
        }
    }

    private void PicExit_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show("Are You Sure You Want To Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.Yes)
        {
            Application.Exit();
        }
    }

    private void LblViewUsers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var viewUsersForm = _serviceProvider.GetRequiredService<ViewUsersForm>();

        viewUsersForm.ShowDialog();
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

    private void HideMenusBasedOnPermissions()
    {
        if (!_tokenProvider.IsSuperUser())
        {
            //Hide Users Management Menus
            LblManageUsersMenu.Visible = false;
            LblCreateUser.Visible = false;
            LblViewUsers.Visible = false;
        }
    }

    private void LblCreateUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var createUserForm = _serviceProvider.GetRequiredService<CreateUserForm>();

        createUserForm.ShowDialog();
    }

    private void BtnReportNow_Click(object sender, EventArgs e)
    {
        using var reportMissingPersonForm = _serviceProvider.GetRequiredService<ReportMissingPersonForm>();

        reportMissingPersonForm.ShowDialog();
    }

    private void LblReportPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var reportMissingPersonForm = _serviceProvider.GetRequiredService<ReportMissingPersonForm>();

        reportMissingPersonForm.ShowDialog();
    }

    private void LblViewGrid_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var missingPersonsGridForm = _serviceProvider.GetRequiredService<MissingPersonsGridForm>();

        missingPersonsGridForm.ShowDialog();
    }

    private void LblModerationQueue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var moderationQueueForm = _serviceProvider.GetRequiredService<ModerationQueueForm>();

        moderationQueueForm.ShowDialog();
    }

    private void LblQueueStats_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var moderationQueueStatsForm = _serviceProvider.GetRequiredService<ModerationQueueStatsForm>();

        moderationQueueStatsForm.ShowDialog();
    }

    private void LblViewDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        var missingPersonsResultsForm = _serviceProvider.GetRequiredService<MissingPersonsResultsForm>();

        missingPersonsResultsForm.ShowDialog();
    }
}