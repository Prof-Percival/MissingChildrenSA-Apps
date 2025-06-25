namespace MissingChildrenSA.Forms;

partial class DashboardForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
        TabPanMain = new TableLayoutPanel();
        PanNavigationMenu = new Panel();
        TabPanNavigation = new TableLayoutPanel();
        TabPanLogoutExit = new TableLayoutPanel();
        PicExit = new PictureBox();
        PicLogout = new PictureBox();
        LblViewUsers = new LinkLabel();
        LblCreateUser = new LinkLabel();
        LblManageUsersMenu = new Label();
        LblQueueStats = new LinkLabel();
        LblModerationQueue = new LinkLabel();
        LblModerationMenu = new Label();
        LblViewGrid = new LinkLabel();
        LblViewDetails = new LinkLabel();
        LblReportPerson = new LinkLabel();
        LblMissingPersonsMenu = new Label();
        PanProfile = new Panel();
        TabPanUserProfile = new TableLayoutPanel();
        LblUserRole = new Label();
        PicUser = new PictureBox();
        LblUserName = new Label();
        PanHeader = new Panel();
        TabPanHeader = new TableLayoutPanel();
        BtnReportNow = new Button();
        BtnDonate = new Button();
        LblContact = new LinkLabel();
        LblChildSafety = new LinkLabel();
        LblGetInvolved = new LinkLabel();
        LblAbout = new LinkLabel();
        PicLogo = new PictureBox();
        LblHome = new LinkLabel();
        PanMain = new Panel();
        TabPanStats = new TableLayoutPanel();
        PicRefresh = new PictureBox();
        TabPanMissingPersonsStatsContainer = new TableLayoutPanel();
        TabPanMissingPersonsStats = new TableLayoutPanel();
        PanFemales = new Panel();
        LblFemales = new Label();
        LblFemalesTitle = new Label();
        PanMales = new Panel();
        LblMales = new Label();
        LblMalesTitle = new Label();
        PanTotalReported = new Panel();
        LblTotalReported = new Label();
        LblTotalReportedTitle = new Label();
        PanRecentlyReported = new Panel();
        LblRecentlyReported = new Label();
        LblRecentlyReportedTitle = new Label();
        TabPanMissingPersonsStatsTitle = new Label();
        TabPanQueueStatsContainer = new TableLayoutPanel();
        TabPanQueueStats = new TableLayoutPanel();
        PanApproved = new Panel();
        LblApproved = new Label();
        LblApprovedTitle = new Label();
        PanFailed = new Panel();
        LblFailed = new Label();
        LblFailedTitle = new Label();
        PanInModeration = new Panel();
        LblInModeration = new Label();
        LblInModerationTitle = new Label();
        PanUnmoderated = new Panel();
        LblUnmoderated = new Label();
        LblUnmoderatedTitle = new Label();
        LblModerationQueueStatsTitle = new Label();
        PanMissingPersonsPerProvince = new Panel();
        MainTooltip = new ToolTip(components);
        TabPanMain.SuspendLayout();
        PanNavigationMenu.SuspendLayout();
        TabPanNavigation.SuspendLayout();
        TabPanLogoutExit.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicExit).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PicLogout).BeginInit();
        PanProfile.SuspendLayout();
        TabPanUserProfile.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicUser).BeginInit();
        PanHeader.SuspendLayout();
        TabPanHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
        PanMain.SuspendLayout();
        TabPanStats.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicRefresh).BeginInit();
        TabPanMissingPersonsStatsContainer.SuspendLayout();
        TabPanMissingPersonsStats.SuspendLayout();
        PanFemales.SuspendLayout();
        PanMales.SuspendLayout();
        PanTotalReported.SuspendLayout();
        PanRecentlyReported.SuspendLayout();
        TabPanQueueStatsContainer.SuspendLayout();
        TabPanQueueStats.SuspendLayout();
        PanApproved.SuspendLayout();
        PanFailed.SuspendLayout();
        PanInModeration.SuspendLayout();
        PanUnmoderated.SuspendLayout();
        SuspendLayout();
        // 
        // TabPanMain
        // 
        TabPanMain.ColumnCount = 2;
        TabPanMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.3897F));
        TabPanMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.6103F));
        TabPanMain.Controls.Add(PanNavigationMenu, 0, 1);
        TabPanMain.Controls.Add(PanProfile, 0, 0);
        TabPanMain.Controls.Add(PanHeader, 1, 0);
        TabPanMain.Controls.Add(PanMain, 1, 1);
        TabPanMain.Dock = DockStyle.Fill;
        TabPanMain.Location = new Point(0, 0);
        TabPanMain.Name = "TabPanMain";
        TabPanMain.RowCount = 2;
        TabPanMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
        TabPanMain.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
        TabPanMain.Size = new Size(914, 510);
        TabPanMain.TabIndex = 0;
        // 
        // PanNavigationMenu
        // 
        PanNavigationMenu.BorderStyle = BorderStyle.FixedSingle;
        PanNavigationMenu.Controls.Add(TabPanNavigation);
        PanNavigationMenu.Dock = DockStyle.Fill;
        PanNavigationMenu.Location = new Point(0, 76);
        PanNavigationMenu.Margin = new Padding(0);
        PanNavigationMenu.Name = "PanNavigationMenu";
        PanNavigationMenu.Size = new Size(158, 434);
        PanNavigationMenu.TabIndex = 0;
        // 
        // TabPanNavigation
        // 
        TabPanNavigation.ColumnCount = 1;
        TabPanNavigation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanNavigation.Controls.Add(TabPanLogoutExit, 0, 17);
        TabPanNavigation.Controls.Add(LblViewUsers, 0, 9);
        TabPanNavigation.Controls.Add(LblCreateUser, 0, 8);
        TabPanNavigation.Controls.Add(LblManageUsersMenu, 0, 7);
        TabPanNavigation.Controls.Add(LblQueueStats, 0, 6);
        TabPanNavigation.Controls.Add(LblModerationQueue, 0, 5);
        TabPanNavigation.Controls.Add(LblModerationMenu, 0, 4);
        TabPanNavigation.Controls.Add(LblViewGrid, 0, 3);
        TabPanNavigation.Controls.Add(LblViewDetails, 0, 2);
        TabPanNavigation.Controls.Add(LblReportPerson, 0, 1);
        TabPanNavigation.Controls.Add(LblMissingPersonsMenu, 0, 0);
        TabPanNavigation.Dock = DockStyle.Fill;
        TabPanNavigation.Location = new Point(0, 0);
        TabPanNavigation.Name = "TabPanNavigation";
        TabPanNavigation.RowCount = 18;
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Percent, 5.555555F));
        TabPanNavigation.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        TabPanNavigation.Size = new Size(156, 432);
        TabPanNavigation.TabIndex = 0;
        // 
        // TabPanLogoutExit
        // 
        TabPanLogoutExit.ColumnCount = 2;
        TabPanLogoutExit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanLogoutExit.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanLogoutExit.Controls.Add(PicExit, 1, 0);
        TabPanLogoutExit.Controls.Add(PicLogout, 0, 0);
        TabPanLogoutExit.Dock = DockStyle.Fill;
        TabPanLogoutExit.Location = new Point(3, 377);
        TabPanLogoutExit.Name = "TabPanLogoutExit";
        TabPanLogoutExit.RowCount = 1;
        TabPanNavigation.SetRowSpan(TabPanLogoutExit, 2);
        TabPanLogoutExit.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanLogoutExit.Size = new Size(150, 52);
        TabPanLogoutExit.TabIndex = 0;
        // 
        // PicExit
        // 
        PicExit.Anchor = AnchorStyles.None;
        PicExit.Cursor = Cursors.Hand;
        PicExit.Image = Properties.Resources.exit;
        PicExit.Location = new Point(92, 6);
        PicExit.Margin = new Padding(0);
        PicExit.MaximumSize = new Size(40, 40);
        PicExit.MinimumSize = new Size(40, 40);
        PicExit.Name = "PicExit";
        PicExit.Size = new Size(40, 40);
        PicExit.SizeMode = PictureBoxSizeMode.StretchImage;
        PicExit.TabIndex = 2;
        PicExit.TabStop = false;
        MainTooltip.SetToolTip(PicExit, "Exit");
        PicExit.Click += PicExit_Click;
        // 
        // PicLogout
        // 
        PicLogout.Anchor = AnchorStyles.None;
        PicLogout.Cursor = Cursors.Hand;
        PicLogout.Image = Properties.Resources.logout;
        PicLogout.Location = new Point(17, 6);
        PicLogout.Margin = new Padding(0);
        PicLogout.MaximumSize = new Size(40, 40);
        PicLogout.MinimumSize = new Size(40, 40);
        PicLogout.Name = "PicLogout";
        PicLogout.Size = new Size(40, 40);
        PicLogout.SizeMode = PictureBoxSizeMode.StretchImage;
        PicLogout.TabIndex = 1;
        PicLogout.TabStop = false;
        MainTooltip.SetToolTip(PicLogout, "Logout");
        PicLogout.Click += PicLogout_Click;
        // 
        // LblViewUsers
        // 
        LblViewUsers.AutoEllipsis = true;
        LblViewUsers.AutoSize = true;
        LblViewUsers.BackColor = Color.Gainsboro;
        LblViewUsers.Dock = DockStyle.Fill;
        LblViewUsers.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblViewUsers.LinkBehavior = LinkBehavior.HoverUnderline;
        LblViewUsers.LinkColor = Color.Black;
        LblViewUsers.Location = new Point(0, 198);
        LblViewUsers.Margin = new Padding(0);
        LblViewUsers.Name = "LblViewUsers";
        LblViewUsers.Padding = new Padding(12, 0, 0, 0);
        LblViewUsers.Size = new Size(156, 22);
        LblViewUsers.TabIndex = 10;
        LblViewUsers.TabStop = true;
        LblViewUsers.Text = "View Users";
        LblViewUsers.TextAlign = ContentAlignment.MiddleLeft;
        LblViewUsers.LinkClicked += LblViewUsers_LinkClicked;
        // 
        // LblCreateUser
        // 
        LblCreateUser.AutoEllipsis = true;
        LblCreateUser.AutoSize = true;
        LblCreateUser.BackColor = Color.Gainsboro;
        LblCreateUser.Dock = DockStyle.Fill;
        LblCreateUser.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblCreateUser.LinkBehavior = LinkBehavior.HoverUnderline;
        LblCreateUser.LinkColor = Color.Black;
        LblCreateUser.Location = new Point(0, 176);
        LblCreateUser.Margin = new Padding(0, 0, 0, 3);
        LblCreateUser.Name = "LblCreateUser";
        LblCreateUser.Padding = new Padding(12, 0, 0, 0);
        LblCreateUser.Size = new Size(156, 19);
        LblCreateUser.TabIndex = 9;
        LblCreateUser.TabStop = true;
        LblCreateUser.Text = "Create User";
        LblCreateUser.TextAlign = ContentAlignment.MiddleLeft;
        LblCreateUser.LinkClicked += LblCreateUser_LinkClicked;
        // 
        // LblManageUsersMenu
        // 
        LblManageUsersMenu.AutoSize = true;
        LblManageUsersMenu.BackColor = Color.Black;
        LblManageUsersMenu.Dock = DockStyle.Fill;
        LblManageUsersMenu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblManageUsersMenu.ForeColor = Color.White;
        LblManageUsersMenu.Location = new Point(0, 154);
        LblManageUsersMenu.Margin = new Padding(0);
        LblManageUsersMenu.Name = "LblManageUsersMenu";
        LblManageUsersMenu.Size = new Size(156, 22);
        LblManageUsersMenu.TabIndex = 8;
        LblManageUsersMenu.Text = "Manage Users";
        LblManageUsersMenu.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblQueueStats
        // 
        LblQueueStats.AutoEllipsis = true;
        LblQueueStats.AutoSize = true;
        LblQueueStats.BackColor = Color.Gainsboro;
        LblQueueStats.Dock = DockStyle.Fill;
        LblQueueStats.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblQueueStats.LinkBehavior = LinkBehavior.HoverUnderline;
        LblQueueStats.LinkColor = Color.Black;
        LblQueueStats.Location = new Point(0, 132);
        LblQueueStats.Margin = new Padding(0);
        LblQueueStats.Name = "LblQueueStats";
        LblQueueStats.Padding = new Padding(12, 0, 0, 0);
        LblQueueStats.Size = new Size(156, 22);
        LblQueueStats.TabIndex = 7;
        LblQueueStats.TabStop = true;
        LblQueueStats.Text = "Queue Stats";
        LblQueueStats.TextAlign = ContentAlignment.MiddleLeft;
        LblQueueStats.LinkClicked += LblQueueStats_LinkClicked;
        // 
        // LblModerationQueue
        // 
        LblModerationQueue.AutoEllipsis = true;
        LblModerationQueue.AutoSize = true;
        LblModerationQueue.BackColor = Color.Gainsboro;
        LblModerationQueue.Dock = DockStyle.Fill;
        LblModerationQueue.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblModerationQueue.LinkBehavior = LinkBehavior.HoverUnderline;
        LblModerationQueue.LinkColor = Color.Black;
        LblModerationQueue.Location = new Point(0, 110);
        LblModerationQueue.Margin = new Padding(0, 0, 0, 3);
        LblModerationQueue.Name = "LblModerationQueue";
        LblModerationQueue.Padding = new Padding(12, 0, 0, 0);
        LblModerationQueue.Size = new Size(156, 19);
        LblModerationQueue.TabIndex = 6;
        LblModerationQueue.TabStop = true;
        LblModerationQueue.Text = "Queue";
        LblModerationQueue.TextAlign = ContentAlignment.MiddleLeft;
        LblModerationQueue.LinkClicked += LblModerationQueue_LinkClicked;
        // 
        // LblModerationMenu
        // 
        LblModerationMenu.AutoSize = true;
        LblModerationMenu.BackColor = Color.Black;
        LblModerationMenu.Dock = DockStyle.Fill;
        LblModerationMenu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblModerationMenu.ForeColor = Color.White;
        LblModerationMenu.Location = new Point(0, 88);
        LblModerationMenu.Margin = new Padding(0);
        LblModerationMenu.Name = "LblModerationMenu";
        LblModerationMenu.Size = new Size(156, 22);
        LblModerationMenu.TabIndex = 5;
        LblModerationMenu.Text = "Moderation";
        LblModerationMenu.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblViewGrid
        // 
        LblViewGrid.AutoEllipsis = true;
        LblViewGrid.AutoSize = true;
        LblViewGrid.BackColor = Color.Gainsboro;
        LblViewGrid.Dock = DockStyle.Fill;
        LblViewGrid.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblViewGrid.LinkBehavior = LinkBehavior.HoverUnderline;
        LblViewGrid.LinkColor = Color.Black;
        LblViewGrid.Location = new Point(0, 66);
        LblViewGrid.Margin = new Padding(0);
        LblViewGrid.Name = "LblViewGrid";
        LblViewGrid.Padding = new Padding(12, 0, 0, 0);
        LblViewGrid.Size = new Size(156, 22);
        LblViewGrid.TabIndex = 4;
        LblViewGrid.TabStop = true;
        LblViewGrid.Text = "View Grid";
        LblViewGrid.TextAlign = ContentAlignment.MiddleLeft;
        LblViewGrid.LinkClicked += LblViewGrid_LinkClicked;
        // 
        // LblViewDetails
        // 
        LblViewDetails.AutoEllipsis = true;
        LblViewDetails.AutoSize = true;
        LblViewDetails.BackColor = Color.Gainsboro;
        LblViewDetails.Dock = DockStyle.Fill;
        LblViewDetails.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblViewDetails.LinkBehavior = LinkBehavior.HoverUnderline;
        LblViewDetails.LinkColor = Color.Black;
        LblViewDetails.Location = new Point(0, 44);
        LblViewDetails.Margin = new Padding(0, 0, 0, 3);
        LblViewDetails.Name = "LblViewDetails";
        LblViewDetails.Padding = new Padding(12, 0, 0, 0);
        LblViewDetails.Size = new Size(156, 19);
        LblViewDetails.TabIndex = 3;
        LblViewDetails.TabStop = true;
        LblViewDetails.Text = "View Details";
        LblViewDetails.TextAlign = ContentAlignment.MiddleLeft;
        LblViewDetails.LinkClicked += LblViewDetails_LinkClicked;
        // 
        // LblReportPerson
        // 
        LblReportPerson.AutoEllipsis = true;
        LblReportPerson.AutoSize = true;
        LblReportPerson.BackColor = Color.Gainsboro;
        LblReportPerson.Dock = DockStyle.Fill;
        LblReportPerson.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblReportPerson.LinkBehavior = LinkBehavior.HoverUnderline;
        LblReportPerson.LinkColor = Color.Black;
        LblReportPerson.Location = new Point(0, 22);
        LblReportPerson.Margin = new Padding(0, 0, 0, 3);
        LblReportPerson.Name = "LblReportPerson";
        LblReportPerson.Padding = new Padding(12, 0, 0, 0);
        LblReportPerson.Size = new Size(156, 19);
        LblReportPerson.TabIndex = 2;
        LblReportPerson.TabStop = true;
        LblReportPerson.Text = "Report";
        LblReportPerson.TextAlign = ContentAlignment.MiddleLeft;
        LblReportPerson.LinkClicked += LblReportPerson_LinkClicked;
        // 
        // LblMissingPersonsMenu
        // 
        LblMissingPersonsMenu.AutoSize = true;
        LblMissingPersonsMenu.BackColor = Color.Black;
        LblMissingPersonsMenu.Dock = DockStyle.Fill;
        LblMissingPersonsMenu.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblMissingPersonsMenu.ForeColor = Color.White;
        LblMissingPersonsMenu.Location = new Point(0, 0);
        LblMissingPersonsMenu.Margin = new Padding(0);
        LblMissingPersonsMenu.Name = "LblMissingPersonsMenu";
        LblMissingPersonsMenu.Size = new Size(156, 22);
        LblMissingPersonsMenu.TabIndex = 0;
        LblMissingPersonsMenu.Text = "Missing Persons";
        LblMissingPersonsMenu.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // PanProfile
        // 
        PanProfile.BorderStyle = BorderStyle.FixedSingle;
        PanProfile.Controls.Add(TabPanUserProfile);
        PanProfile.Dock = DockStyle.Fill;
        PanProfile.Location = new Point(0, 0);
        PanProfile.Margin = new Padding(0);
        PanProfile.Name = "PanProfile";
        PanProfile.Size = new Size(158, 76);
        PanProfile.TabIndex = 1;
        // 
        // TabPanUserProfile
        // 
        TabPanUserProfile.ColumnCount = 1;
        TabPanUserProfile.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanUserProfile.Controls.Add(LblUserRole, 0, 2);
        TabPanUserProfile.Controls.Add(PicUser, 0, 0);
        TabPanUserProfile.Controls.Add(LblUserName, 0, 1);
        TabPanUserProfile.Dock = DockStyle.Fill;
        TabPanUserProfile.Location = new Point(0, 0);
        TabPanUserProfile.Margin = new Padding(0);
        TabPanUserProfile.Name = "TabPanUserProfile";
        TabPanUserProfile.RowCount = 3;
        TabPanUserProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
        TabPanUserProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        TabPanUserProfile.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
        TabPanUserProfile.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        TabPanUserProfile.Size = new Size(156, 74);
        TabPanUserProfile.TabIndex = 0;
        // 
        // LblUserRole
        // 
        LblUserRole.AutoEllipsis = true;
        LblUserRole.Dock = DockStyle.Fill;
        LblUserRole.Font = new Font("Arial", 9.75F, FontStyle.Bold);
        LblUserRole.Location = new Point(3, 58);
        LblUserRole.Name = "LblUserRole";
        LblUserRole.RightToLeft = RightToLeft.No;
        LblUserRole.Size = new Size(150, 16);
        LblUserRole.TabIndex = 1;
        LblUserRole.Text = "[ User Role ]";
        LblUserRole.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PicUser
        // 
        PicUser.Anchor = AnchorStyles.None;
        PicUser.Image = Properties.Resources.user;
        PicUser.Location = new Point(57, 1);
        PicUser.Margin = new Padding(0);
        PicUser.MaximumSize = new Size(42, 42);
        PicUser.MinimumSize = new Size(42, 42);
        PicUser.Name = "PicUser";
        PicUser.Size = new Size(42, 42);
        PicUser.SizeMode = PictureBoxSizeMode.StretchImage;
        PicUser.TabIndex = 0;
        PicUser.TabStop = false;
        // 
        // LblUserName
        // 
        LblUserName.AutoEllipsis = true;
        LblUserName.Dock = DockStyle.Fill;
        LblUserName.Font = new Font("Arial", 9.75F, FontStyle.Bold);
        LblUserName.Location = new Point(3, 44);
        LblUserName.Name = "LblUserName";
        LblUserName.RightToLeft = RightToLeft.No;
        LblUserName.Size = new Size(150, 14);
        LblUserName.TabIndex = 0;
        LblUserName.Text = "User Full Name";
        LblUserName.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanHeader
        // 
        PanHeader.BorderStyle = BorderStyle.FixedSingle;
        PanHeader.Controls.Add(TabPanHeader);
        PanHeader.Dock = DockStyle.Fill;
        PanHeader.Location = new Point(158, 0);
        PanHeader.Margin = new Padding(0);
        PanHeader.Name = "PanHeader";
        PanHeader.Size = new Size(756, 76);
        PanHeader.TabIndex = 2;
        // 
        // TabPanHeader
        // 
        TabPanHeader.ColumnCount = 8;
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11F));
        TabPanHeader.Controls.Add(BtnReportNow, 7, 0);
        TabPanHeader.Controls.Add(BtnDonate, 6, 0);
        TabPanHeader.Controls.Add(LblContact, 5, 0);
        TabPanHeader.Controls.Add(LblChildSafety, 4, 0);
        TabPanHeader.Controls.Add(LblGetInvolved, 3, 0);
        TabPanHeader.Controls.Add(LblAbout, 2, 0);
        TabPanHeader.Controls.Add(PicLogo, 0, 0);
        TabPanHeader.Controls.Add(LblHome, 1, 0);
        TabPanHeader.Dock = DockStyle.Fill;
        TabPanHeader.Location = new Point(0, 0);
        TabPanHeader.Name = "TabPanHeader";
        TabPanHeader.RowCount = 1;
        TabPanHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TabPanHeader.Size = new Size(754, 74);
        TabPanHeader.TabIndex = 0;
        // 
        // BtnReportNow
        // 
        BtnReportNow.Anchor = AnchorStyles.None;
        BtnReportNow.AutoSize = true;
        BtnReportNow.BackColor = Color.FromArgb(237, 31, 39);
        BtnReportNow.Cursor = Cursors.Hand;
        BtnReportNow.FlatAppearance.BorderSize = 0;
        BtnReportNow.FlatStyle = FlatStyle.Flat;
        BtnReportNow.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnReportNow.ForeColor = Color.White;
        BtnReportNow.Location = new Point(670, 21);
        BtnReportNow.Margin = new Padding(5, 3, 5, 3);
        BtnReportNow.Name = "BtnReportNow";
        BtnReportNow.Size = new Size(79, 31);
        BtnReportNow.TabIndex = 7;
        BtnReportNow.Text = "Report Now";
        BtnReportNow.UseVisualStyleBackColor = false;
        BtnReportNow.Click += BtnReportNow_Click;
        // 
        // BtnDonate
        // 
        BtnDonate.Anchor = AnchorStyles.None;
        BtnDonate.AutoSize = true;
        BtnDonate.BackColor = Color.FromArgb(237, 31, 39);
        BtnDonate.Cursor = Cursors.Hand;
        BtnDonate.FlatAppearance.BorderSize = 0;
        BtnDonate.FlatStyle = FlatStyle.Flat;
        BtnDonate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnDonate.ForeColor = Color.White;
        BtnDonate.Location = new Point(588, 21);
        BtnDonate.Margin = new Padding(5, 3, 5, 3);
        BtnDonate.Name = "BtnDonate";
        BtnDonate.Size = new Size(72, 31);
        BtnDonate.TabIndex = 6;
        BtnDonate.Text = "Donate";
        BtnDonate.UseVisualStyleBackColor = false;
        BtnDonate.Click += BtnDonate_Click;
        // 
        // LblContact
        // 
        LblContact.Anchor = AnchorStyles.None;
        LblContact.AutoSize = true;
        LblContact.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblContact.LinkBehavior = LinkBehavior.HoverUnderline;
        LblContact.LinkColor = Color.Black;
        LblContact.Location = new Point(507, 27);
        LblContact.Name = "LblContact";
        LblContact.Size = new Size(69, 19);
        LblContact.TabIndex = 5;
        LblContact.TabStop = true;
        LblContact.Text = "Contact";
        LblContact.LinkClicked += LblContact_LinkClicked;
        // 
        // LblChildSafety
        // 
        LblChildSafety.Anchor = AnchorStyles.None;
        LblChildSafety.AutoSize = true;
        LblChildSafety.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblChildSafety.LinkBehavior = LinkBehavior.HoverUnderline;
        LblChildSafety.LinkColor = Color.Black;
        LblChildSafety.Location = new Point(431, 18);
        LblChildSafety.Name = "LblChildSafety";
        LblChildSafety.Size = new Size(57, 38);
        LblChildSafety.TabIndex = 4;
        LblChildSafety.TabStop = true;
        LblChildSafety.Text = "Child Safety";
        LblChildSafety.LinkClicked += LblChildSafety_LinkClicked;
        // 
        // LblGetInvolved
        // 
        LblGetInvolved.Anchor = AnchorStyles.None;
        LblGetInvolved.AutoSize = true;
        LblGetInvolved.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblGetInvolved.LinkBehavior = LinkBehavior.HoverUnderline;
        LblGetInvolved.LinkColor = Color.Black;
        LblGetInvolved.Location = new Point(341, 18);
        LblGetInvolved.Name = "LblGetInvolved";
        LblGetInvolved.Size = new Size(74, 38);
        LblGetInvolved.TabIndex = 3;
        LblGetInvolved.TabStop = true;
        LblGetInvolved.Text = "Get Involved";
        LblGetInvolved.LinkClicked += LblGetInvolved_LinkClicked;
        // 
        // LblAbout
        // 
        LblAbout.Anchor = AnchorStyles.None;
        LblAbout.AutoSize = true;
        LblAbout.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblAbout.LinkBehavior = LinkBehavior.HoverUnderline;
        LblAbout.LinkColor = Color.Black;
        LblAbout.Location = new Point(266, 18);
        LblAbout.Name = "LblAbout";
        LblAbout.Size = new Size(59, 38);
        LblAbout.TabIndex = 2;
        LblAbout.TabStop = true;
        LblAbout.Text = "About Us";
        LblAbout.LinkClicked += LblAbout_LinkClicked;
        // 
        // PicLogo
        // 
        PicLogo.Anchor = AnchorStyles.Left;
        PicLogo.Image = Properties.Resources._180x80_MCSA_Logo_20122019;
        PicLogo.Location = new Point(3, 3);
        PicLogo.Name = "PicLogo";
        PicLogo.Size = new Size(150, 68);
        PicLogo.SizeMode = PictureBoxSizeMode.Zoom;
        PicLogo.TabIndex = 0;
        PicLogo.TabStop = false;
        // 
        // LblHome
        // 
        LblHome.Anchor = AnchorStyles.None;
        LblHome.AutoSize = true;
        LblHome.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblHome.LinkBehavior = LinkBehavior.HoverUnderline;
        LblHome.LinkColor = Color.Black;
        LblHome.Location = new Point(187, 27);
        LblHome.Name = "LblHome";
        LblHome.Size = new Size(54, 19);
        LblHome.TabIndex = 1;
        LblHome.TabStop = true;
        LblHome.Text = "Home";
        LblHome.LinkClicked += LblHome_LinkClicked;
        // 
        // PanMain
        // 
        PanMain.BorderStyle = BorderStyle.FixedSingle;
        PanMain.Controls.Add(TabPanStats);
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(158, 76);
        PanMain.Margin = new Padding(0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(756, 434);
        PanMain.TabIndex = 3;
        // 
        // TabPanStats
        // 
        TabPanStats.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        TabPanStats.ColumnCount = 2;
        TabPanStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanStats.Controls.Add(PicRefresh, 1, 1);
        TabPanStats.Controls.Add(TabPanMissingPersonsStatsContainer, 1, 0);
        TabPanStats.Controls.Add(TabPanQueueStatsContainer, 0, 0);
        TabPanStats.Controls.Add(PanMissingPersonsPerProvince, 0, 1);
        TabPanStats.Dock = DockStyle.Fill;
        TabPanStats.Location = new Point(0, 0);
        TabPanStats.Name = "TabPanStats";
        TabPanStats.RowCount = 2;
        TabPanStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanStats.Size = new Size(754, 432);
        TabPanStats.TabIndex = 0;
        // 
        // PicRefresh
        // 
        PicRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        PicRefresh.Cursor = Cursors.Hand;
        PicRefresh.Image = Properties.Resources.refresh;
        PicRefresh.Location = new Point(710, 395);
        PicRefresh.Margin = new Padding(10, 3, 3, 3);
        PicRefresh.Name = "PicRefresh";
        PicRefresh.Size = new Size(40, 33);
        PicRefresh.SizeMode = PictureBoxSizeMode.Zoom;
        PicRefresh.TabIndex = 3;
        PicRefresh.TabStop = false;
        MainTooltip.SetToolTip(PicRefresh, "Refresh");
        PicRefresh.Click += PicRefresh_Click;
        // 
        // TabPanMissingPersonsStatsContainer
        // 
        TabPanMissingPersonsStatsContainer.ColumnCount = 1;
        TabPanMissingPersonsStatsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanMissingPersonsStatsContainer.Controls.Add(TabPanMissingPersonsStats, 0, 1);
        TabPanMissingPersonsStatsContainer.Controls.Add(TabPanMissingPersonsStatsTitle, 0, 0);
        TabPanMissingPersonsStatsContainer.Dock = DockStyle.Fill;
        TabPanMissingPersonsStatsContainer.Location = new Point(380, 4);
        TabPanMissingPersonsStatsContainer.Name = "TabPanMissingPersonsStatsContainer";
        TabPanMissingPersonsStatsContainer.RowCount = 2;
        TabPanMissingPersonsStatsContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        TabPanMissingPersonsStatsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TabPanMissingPersonsStatsContainer.Size = new Size(370, 208);
        TabPanMissingPersonsStatsContainer.TabIndex = 1;
        // 
        // TabPanMissingPersonsStats
        // 
        TabPanMissingPersonsStats.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        TabPanMissingPersonsStats.ColumnCount = 2;
        TabPanMissingPersonsStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanMissingPersonsStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanMissingPersonsStats.Controls.Add(PanFemales, 1, 1);
        TabPanMissingPersonsStats.Controls.Add(PanMales, 0, 1);
        TabPanMissingPersonsStats.Controls.Add(PanTotalReported, 1, 0);
        TabPanMissingPersonsStats.Controls.Add(PanRecentlyReported, 0, 0);
        TabPanMissingPersonsStats.Dock = DockStyle.Fill;
        TabPanMissingPersonsStats.Location = new Point(3, 23);
        TabPanMissingPersonsStats.Name = "TabPanMissingPersonsStats";
        TabPanMissingPersonsStats.RowCount = 2;
        TabPanMissingPersonsStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanMissingPersonsStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanMissingPersonsStats.Size = new Size(364, 182);
        TabPanMissingPersonsStats.TabIndex = 1;
        // 
        // PanFemales
        // 
        PanFemales.Controls.Add(LblFemales);
        PanFemales.Controls.Add(LblFemalesTitle);
        PanFemales.Dock = DockStyle.Fill;
        PanFemales.Location = new Point(185, 94);
        PanFemales.Name = "PanFemales";
        PanFemales.Size = new Size(175, 84);
        PanFemales.TabIndex = 3;
        // 
        // LblFemales
        // 
        LblFemales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblFemales.AutoEllipsis = true;
        LblFemales.Font = new Font("Arial", 24F, FontStyle.Bold);
        LblFemales.Location = new Point(3, 27);
        LblFemales.Name = "LblFemales";
        LblFemales.Size = new Size(168, 55);
        LblFemales.TabIndex = 1;
        LblFemales.Text = "0";
        LblFemales.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblFemalesTitle
        // 
        LblFemalesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblFemalesTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblFemalesTitle.Location = new Point(3, 4);
        LblFemalesTitle.Name = "LblFemalesTitle";
        LblFemalesTitle.Size = new Size(168, 29);
        LblFemalesTitle.TabIndex = 0;
        LblFemalesTitle.Text = "Females";
        LblFemalesTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanMales
        // 
        PanMales.Controls.Add(LblMales);
        PanMales.Controls.Add(LblMalesTitle);
        PanMales.Dock = DockStyle.Fill;
        PanMales.Location = new Point(4, 94);
        PanMales.Name = "PanMales";
        PanMales.Size = new Size(174, 84);
        PanMales.TabIndex = 2;
        // 
        // LblMales
        // 
        LblMales.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblMales.AutoEllipsis = true;
        LblMales.Font = new Font("Arial", 24F, FontStyle.Bold);
        LblMales.Location = new Point(3, 27);
        LblMales.Name = "LblMales";
        LblMales.Size = new Size(168, 55);
        LblMales.TabIndex = 1;
        LblMales.Text = "0";
        LblMales.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblMalesTitle
        // 
        LblMalesTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblMalesTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblMalesTitle.Location = new Point(3, 4);
        LblMalesTitle.Name = "LblMalesTitle";
        LblMalesTitle.Size = new Size(168, 29);
        LblMalesTitle.TabIndex = 0;
        LblMalesTitle.Text = "Males";
        LblMalesTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanTotalReported
        // 
        PanTotalReported.Controls.Add(LblTotalReported);
        PanTotalReported.Controls.Add(LblTotalReportedTitle);
        PanTotalReported.Dock = DockStyle.Fill;
        PanTotalReported.Location = new Point(185, 4);
        PanTotalReported.Name = "PanTotalReported";
        PanTotalReported.Size = new Size(175, 83);
        PanTotalReported.TabIndex = 1;
        // 
        // LblTotalReported
        // 
        LblTotalReported.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblTotalReported.AutoEllipsis = true;
        LblTotalReported.Font = new Font("Arial", 24F, FontStyle.Bold);
        LblTotalReported.Location = new Point(3, 33);
        LblTotalReported.Name = "LblTotalReported";
        LblTotalReported.Size = new Size(168, 46);
        LblTotalReported.TabIndex = 1;
        LblTotalReported.Text = "0";
        LblTotalReported.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblTotalReportedTitle
        // 
        LblTotalReportedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblTotalReportedTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblTotalReportedTitle.Location = new Point(3, 4);
        LblTotalReportedTitle.Name = "LblTotalReportedTitle";
        LblTotalReportedTitle.Size = new Size(168, 29);
        LblTotalReportedTitle.TabIndex = 0;
        LblTotalReportedTitle.Text = "Total Reported";
        LblTotalReportedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanRecentlyReported
        // 
        PanRecentlyReported.Controls.Add(LblRecentlyReported);
        PanRecentlyReported.Controls.Add(LblRecentlyReportedTitle);
        PanRecentlyReported.Dock = DockStyle.Fill;
        PanRecentlyReported.Location = new Point(4, 4);
        PanRecentlyReported.Name = "PanRecentlyReported";
        PanRecentlyReported.Size = new Size(174, 83);
        PanRecentlyReported.TabIndex = 0;
        // 
        // LblRecentlyReported
        // 
        LblRecentlyReported.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblRecentlyReported.AutoEllipsis = true;
        LblRecentlyReported.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRecentlyReported.Location = new Point(3, 33);
        LblRecentlyReported.Name = "LblRecentlyReported";
        LblRecentlyReported.Size = new Size(168, 46);
        LblRecentlyReported.TabIndex = 1;
        LblRecentlyReported.Text = "0";
        LblRecentlyReported.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblRecentlyReportedTitle
        // 
        LblRecentlyReportedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblRecentlyReportedTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblRecentlyReportedTitle.Location = new Point(3, 4);
        LblRecentlyReportedTitle.Name = "LblRecentlyReportedTitle";
        LblRecentlyReportedTitle.Size = new Size(168, 29);
        LblRecentlyReportedTitle.TabIndex = 0;
        LblRecentlyReportedTitle.Text = "Recently Reported";
        LblRecentlyReportedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TabPanMissingPersonsStatsTitle
        // 
        TabPanMissingPersonsStatsTitle.AutoSize = true;
        TabPanMissingPersonsStatsTitle.Dock = DockStyle.Fill;
        TabPanMissingPersonsStatsTitle.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        TabPanMissingPersonsStatsTitle.Location = new Point(3, 0);
        TabPanMissingPersonsStatsTitle.Name = "TabPanMissingPersonsStatsTitle";
        TabPanMissingPersonsStatsTitle.Size = new Size(364, 20);
        TabPanMissingPersonsStatsTitle.TabIndex = 0;
        TabPanMissingPersonsStatsTitle.Text = "Missing Persons Stats";
        TabPanMissingPersonsStatsTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // TabPanQueueStatsContainer
        // 
        TabPanQueueStatsContainer.ColumnCount = 1;
        TabPanQueueStatsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanQueueStatsContainer.Controls.Add(TabPanQueueStats, 0, 1);
        TabPanQueueStatsContainer.Controls.Add(LblModerationQueueStatsTitle, 0, 0);
        TabPanQueueStatsContainer.Dock = DockStyle.Fill;
        TabPanQueueStatsContainer.Location = new Point(4, 4);
        TabPanQueueStatsContainer.Name = "TabPanQueueStatsContainer";
        TabPanQueueStatsContainer.RowCount = 2;
        TabPanQueueStatsContainer.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        TabPanQueueStatsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TabPanQueueStatsContainer.Size = new Size(369, 208);
        TabPanQueueStatsContainer.TabIndex = 0;
        // 
        // TabPanQueueStats
        // 
        TabPanQueueStats.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        TabPanQueueStats.ColumnCount = 2;
        TabPanQueueStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanQueueStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanQueueStats.Controls.Add(PanApproved, 1, 1);
        TabPanQueueStats.Controls.Add(PanFailed, 0, 1);
        TabPanQueueStats.Controls.Add(PanInModeration, 1, 0);
        TabPanQueueStats.Controls.Add(PanUnmoderated, 0, 0);
        TabPanQueueStats.Dock = DockStyle.Fill;
        TabPanQueueStats.Location = new Point(3, 23);
        TabPanQueueStats.Name = "TabPanQueueStats";
        TabPanQueueStats.RowCount = 2;
        TabPanQueueStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanQueueStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanQueueStats.Size = new Size(363, 182);
        TabPanQueueStats.TabIndex = 1;
        // 
        // PanApproved
        // 
        PanApproved.Controls.Add(LblApproved);
        PanApproved.Controls.Add(LblApprovedTitle);
        PanApproved.Dock = DockStyle.Fill;
        PanApproved.Location = new Point(185, 94);
        PanApproved.Name = "PanApproved";
        PanApproved.Size = new Size(174, 84);
        PanApproved.TabIndex = 3;
        // 
        // LblApproved
        // 
        LblApproved.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblApproved.AutoEllipsis = true;
        LblApproved.Font = new Font("Arial", 24F, FontStyle.Bold);
        LblApproved.Location = new Point(3, 27);
        LblApproved.Name = "LblApproved";
        LblApproved.Size = new Size(168, 55);
        LblApproved.TabIndex = 1;
        LblApproved.Text = "0";
        LblApproved.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblApprovedTitle
        // 
        LblApprovedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblApprovedTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblApprovedTitle.Location = new Point(3, 4);
        LblApprovedTitle.Name = "LblApprovedTitle";
        LblApprovedTitle.Size = new Size(168, 29);
        LblApprovedTitle.TabIndex = 0;
        LblApprovedTitle.Text = "Approved";
        LblApprovedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanFailed
        // 
        PanFailed.Controls.Add(LblFailed);
        PanFailed.Controls.Add(LblFailedTitle);
        PanFailed.Dock = DockStyle.Fill;
        PanFailed.Location = new Point(4, 94);
        PanFailed.Name = "PanFailed";
        PanFailed.Size = new Size(174, 84);
        PanFailed.TabIndex = 2;
        // 
        // LblFailed
        // 
        LblFailed.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblFailed.AutoEllipsis = true;
        LblFailed.Font = new Font("Arial", 24F, FontStyle.Bold);
        LblFailed.Location = new Point(3, 27);
        LblFailed.Name = "LblFailed";
        LblFailed.Size = new Size(168, 55);
        LblFailed.TabIndex = 1;
        LblFailed.Text = "0";
        LblFailed.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblFailedTitle
        // 
        LblFailedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblFailedTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblFailedTitle.Location = new Point(3, 4);
        LblFailedTitle.Name = "LblFailedTitle";
        LblFailedTitle.Size = new Size(168, 29);
        LblFailedTitle.TabIndex = 0;
        LblFailedTitle.Text = "Failed";
        LblFailedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanInModeration
        // 
        PanInModeration.Controls.Add(LblInModeration);
        PanInModeration.Controls.Add(LblInModerationTitle);
        PanInModeration.Dock = DockStyle.Fill;
        PanInModeration.Location = new Point(185, 4);
        PanInModeration.Name = "PanInModeration";
        PanInModeration.Size = new Size(174, 83);
        PanInModeration.TabIndex = 1;
        // 
        // LblInModeration
        // 
        LblInModeration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblInModeration.AutoEllipsis = true;
        LblInModeration.Font = new Font("Arial", 24F, FontStyle.Bold);
        LblInModeration.Location = new Point(3, 24);
        LblInModeration.Name = "LblInModeration";
        LblInModeration.Size = new Size(168, 55);
        LblInModeration.TabIndex = 1;
        LblInModeration.Text = "0";
        LblInModeration.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblInModerationTitle
        // 
        LblInModerationTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblInModerationTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblInModerationTitle.Location = new Point(3, 4);
        LblInModerationTitle.Name = "LblInModerationTitle";
        LblInModerationTitle.Size = new Size(168, 29);
        LblInModerationTitle.TabIndex = 0;
        LblInModerationTitle.Text = "In Moderation";
        LblInModerationTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanUnmoderated
        // 
        PanUnmoderated.Controls.Add(LblUnmoderated);
        PanUnmoderated.Controls.Add(LblUnmoderatedTitle);
        PanUnmoderated.Dock = DockStyle.Fill;
        PanUnmoderated.Location = new Point(4, 4);
        PanUnmoderated.Name = "PanUnmoderated";
        PanUnmoderated.Size = new Size(174, 83);
        PanUnmoderated.TabIndex = 0;
        // 
        // LblUnmoderated
        // 
        LblUnmoderated.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblUnmoderated.AutoEllipsis = true;
        LblUnmoderated.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblUnmoderated.Location = new Point(3, 24);
        LblUnmoderated.Name = "LblUnmoderated";
        LblUnmoderated.Size = new Size(168, 55);
        LblUnmoderated.TabIndex = 1;
        LblUnmoderated.Text = "0";
        LblUnmoderated.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblUnmoderatedTitle
        // 
        LblUnmoderatedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblUnmoderatedTitle.Font = new Font("Arial", 12F, FontStyle.Bold);
        LblUnmoderatedTitle.Location = new Point(3, 4);
        LblUnmoderatedTitle.Name = "LblUnmoderatedTitle";
        LblUnmoderatedTitle.Size = new Size(168, 29);
        LblUnmoderatedTitle.TabIndex = 0;
        LblUnmoderatedTitle.Text = "Unmoderated";
        LblUnmoderatedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblModerationQueueStatsTitle
        // 
        LblModerationQueueStatsTitle.AutoSize = true;
        LblModerationQueueStatsTitle.Dock = DockStyle.Fill;
        LblModerationQueueStatsTitle.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblModerationQueueStatsTitle.Location = new Point(3, 0);
        LblModerationQueueStatsTitle.Name = "LblModerationQueueStatsTitle";
        LblModerationQueueStatsTitle.Size = new Size(363, 20);
        LblModerationQueueStatsTitle.TabIndex = 0;
        LblModerationQueueStatsTitle.Text = "Moderation Queue Stats";
        LblModerationQueueStatsTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanMissingPersonsPerProvince
        // 
        PanMissingPersonsPerProvince.Dock = DockStyle.Fill;
        PanMissingPersonsPerProvince.Location = new Point(4, 219);
        PanMissingPersonsPerProvince.Name = "PanMissingPersonsPerProvince";
        PanMissingPersonsPerProvince.Size = new Size(369, 209);
        PanMissingPersonsPerProvince.TabIndex = 2;
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(914, 510);
        Controls.Add(TabPanMain);
        Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "DashboardForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Missing Children SA";
        FormClosed += DashboardForm_FormClosed;
        Load += DashboardForm_Load;
        Activated += DashboardForm_Activated;
        TabPanMain.ResumeLayout(false);
        PanNavigationMenu.ResumeLayout(false);
        TabPanNavigation.ResumeLayout(false);
        TabPanNavigation.PerformLayout();
        TabPanLogoutExit.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicExit).EndInit();
        ((System.ComponentModel.ISupportInitialize)PicLogout).EndInit();
        PanProfile.ResumeLayout(false);
        TabPanUserProfile.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicUser).EndInit();
        PanHeader.ResumeLayout(false);
        TabPanHeader.ResumeLayout(false);
        TabPanHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
        PanMain.ResumeLayout(false);
        TabPanStats.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicRefresh).EndInit();
        TabPanMissingPersonsStatsContainer.ResumeLayout(false);
        TabPanMissingPersonsStatsContainer.PerformLayout();
        TabPanMissingPersonsStats.ResumeLayout(false);
        PanFemales.ResumeLayout(false);
        PanMales.ResumeLayout(false);
        PanTotalReported.ResumeLayout(false);
        PanRecentlyReported.ResumeLayout(false);
        TabPanQueueStatsContainer.ResumeLayout(false);
        TabPanQueueStatsContainer.PerformLayout();
        TabPanQueueStats.ResumeLayout(false);
        PanApproved.ResumeLayout(false);
        PanFailed.ResumeLayout(false);
        PanInModeration.ResumeLayout(false);
        PanUnmoderated.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TabPanMain;
    private Panel PanNavigationMenu;
    private Panel PanProfile;
    private Panel PanHeader;
    private Panel PanMain;
    private PictureBox PicUser;
    private Label LblUserName;
    private Label LblUserRole;
    private TableLayoutPanel TabPanUserProfile;
    private TableLayoutPanel TabPanHeader;
    private PictureBox PicLogo;
    private LinkLabel LblHome;
    private LinkLabel LblAbout;
    private LinkLabel LblGetInvolved;
    private LinkLabel LblChildSafety;
    private LinkLabel LblContact;
    private Button BtnDonate;
    private Button BtnReportNow;
    private TableLayoutPanel TabPanNavigation;
    private Label LblMissingPersonsMenu;
    private LinkLabel LblReportPerson;
    private LinkLabel LblViewDetails;
    private Label LblModerationMenu;
    private LinkLabel LblViewGrid;
    private LinkLabel LblModerationQueue;
    private LinkLabel LblQueueStats;
    private LinkLabel LblViewUsers;
    private LinkLabel LblCreateUser;
    private Label LblManageUsersMenu;
    private TableLayoutPanel TabPanLogoutExit;
    private PictureBox PicExit;
    private PictureBox PicLogout;
    private ToolTip MainTooltip;
    private TableLayoutPanel TabPanStats;
    private TableLayoutPanel TabPanQueueStatsContainer;
    private TableLayoutPanel TabPanQueueStats;
    private Panel PanApproved;
    private Label LblApproved;
    private Label LblApprovedTitle;
    private Panel PanFailed;
    private Label LblFailed;
    private Label LblFailedTitle;
    private Panel PanInModeration;
    private Label LblInModeration;
    private Label LblInModerationTitle;
    private Panel PanUnmoderated;
    private Label LblUnmoderated;
    private Label LblUnmoderatedTitle;
    private Label LblModerationQueueStatsTitle;
    private TableLayoutPanel TabPanMissingPersonsStatsContainer;
    private TableLayoutPanel TabPanMissingPersonsStats;
    private Panel PanFemales;
    private Label LblFemales;
    private Label LblFemalesTitle;
    private Panel PanMales;
    private Label LblMales;
    private Label LblMalesTitle;
    private Panel PanTotalReported;
    private Label LblTotalReported;
    private Label LblTotalReportedTitle;
    private Panel PanRecentlyReported;
    private Label LblRecentlyReported;
    private Label LblRecentlyReportedTitle;
    private Label TabPanMissingPersonsStatsTitle;
    private Panel PanMissingPersonsPerProvince;
    private PictureBox PicRefresh;
}