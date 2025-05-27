using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Forms.MissingPersons;
using MissingChildrenSA.Forms.Moderation;
using MissingChildrenSA.Forms.Users;
using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Models.Users;
using MissingChildrenSA.Services.Auth;
using MissingChildrenSA.Services.Users;
using System.Windows.Forms.DataVisualization.Charting;

namespace MissingChildrenSA.Forms;

public partial class DashboardForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly CurrentUserService _currentUserService;
    private readonly ITokenProvider _tokenProvider;
    private readonly IServiceProvider _serviceProvider;
    private readonly ApiClient _apiClient;

    private CurrentUser _currentUser;

    public DashboardForm(
        EnumLoader enumLoader,
        CurrentUserService currentUserService,
        ITokenProvider tokenProvider,
        IServiceProvider serviceProvider,
        ApiClient apiClient)
    {
        InitializeComponent();

        _enumLoader = enumLoader;
        _currentUserService = currentUserService;
        _tokenProvider = tokenProvider;
        _serviceProvider = serviceProvider;
        _apiClient = apiClient;
    }

    private async void DashboardForm_Load(object sender, EventArgs e)
    {
        HideMenusBasedOnPermissions();

        MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        WindowState = FormWindowState.Maximized;

        _currentUser = await _currentUserService.GetCurrentUser();

        await _enumLoader.LoadEnumsAsync();

        PopulateUserProfile();

        await BuildStatisticsAsync();
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

        if (!_tokenProvider.IsSuperUser() &&
            !_tokenProvider.IsOperationalSupport())
        {
            //Hide Moderation Menus
            LblModerationMenu.Visible = false;
            LblModerationQueue.Visible = false;
            LblQueueStats.Visible = false;
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

    private async Task BuildStatisticsAsync()
    {
        try
        {
            var statistics = await _apiClient.GetMainStatisticsAsync();

            PopulateModerationQueueStats(statistics);

            PopulateMissingPersonsStats(statistics);

            LoadMissingPersonsPerProvinceChart(statistics);
        }
        catch
        {
            //Silently pass
        }
    }

    private void PopulateModerationQueueStats(MainStatisticsModel statistics)
    {
        var queueStats = statistics.ModerationQueueStats;

        LblUnmoderated.Text = queueStats.Unmoderated.ToString();
        LblInModeration.Text = queueStats.InModeration.ToString();
        LblFailed.Text = queueStats.Failed.ToString();
        LblApproved.Text = queueStats.Approved.ToString();
    }

    private void PopulateMissingPersonsStats(MainStatisticsModel statistics)
    {
        var missingPersonsStats = statistics.MissingPersonsStats;

        LblNewlyReported.Text = missingPersonsStats.RecentlyReported.ToString();
        LblTotalReported.Text = missingPersonsStats.TotalReported.ToString();
        LblMales.Text = missingPersonsStats.Males.ToString();
        LblFemales.Text = missingPersonsStats.Females.ToString();
    }

    private void LoadMissingPersonsPerProvinceChart(MainStatisticsModel statistics)
    {
        var chart = new Chart
        {
            Dock = DockStyle.Fill,
            BackColor = Color.White
        };

        // Add chart area
        var chartArea = new ChartArea("MainArea");
        chartArea.AxisX.Title = "Province";
        chartArea.AxisY.Title = "Number of Missing Persons";

        // Remove gridlines
        chartArea.AxisX.MajorGrid.Enabled = false;
        chartArea.AxisY.MajorGrid.Enabled = false;

        chart.ChartAreas.Add(chartArea);

        // Add title
        chart.Titles.Add(new Title(
            "Missing Persons by Province",
            Docking.Top,
            new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
            Color.Black));

        // Series
        var series = new Series("Missing Persons")
        {
            ChartType = SeriesChartType.Bar,
            IsValueShownAsLabel = true
        };

        chart.Series.Add(series);

        // Define a color palette or randomize
        Color[] barColors =
        [
            Color.SteelBlue, Color.Teal, Color.IndianRed, Color.DarkOrange,
            Color.DarkGreen, Color.MediumPurple, Color.CadetBlue,
            Color.Goldenrod, Color.SlateGray
        ];

        var colorIndex = 0;

        foreach (var stat in statistics.StatsByProvince)
        {
            int pointIndex = series.Points.AddXY(stat.Province, stat.Count);
            series.Points[pointIndex].Color = barColors[colorIndex % barColors.Length];
            colorIndex++;
        }

        // Clear and add chart to panel
        PanMissingPersonsPerProvince.Controls.Clear();
        PanMissingPersonsPerProvince.Controls.Add(chart);
    }
}