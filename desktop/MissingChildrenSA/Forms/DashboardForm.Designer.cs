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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
        TabPanMain = new TableLayoutPanel();
        PanNavigationMenu = new Panel();
        PanProfile = new Panel();
        TabPanUserProfile = new TableLayoutPanel();
        LblUserRole = new Label();
        PicUser = new PictureBox();
        LblUserName = new Label();
        PanHeader = new Panel();
        TabPanHeader = new TableLayoutPanel();
        BtnDonate = new Button();
        LblContact = new LinkLabel();
        LblChildSafety = new LinkLabel();
        LblGetInvolved = new LinkLabel();
        LblAbout = new LinkLabel();
        PicLogo = new PictureBox();
        LblHome = new LinkLabel();
        PanMain = new Panel();
        TabPanMain.SuspendLayout();
        PanProfile.SuspendLayout();
        TabPanUserProfile.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicUser).BeginInit();
        PanHeader.SuspendLayout();
        TabPanHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicLogo).BeginInit();
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
        PanNavigationMenu.Dock = DockStyle.Fill;
        PanNavigationMenu.Location = new Point(0, 76);
        PanNavigationMenu.Margin = new Padding(0);
        PanNavigationMenu.Name = "PanNavigationMenu";
        PanNavigationMenu.Size = new Size(158, 434);
        PanNavigationMenu.TabIndex = 0;
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
        LblUserRole.Text = "User Role";
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
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(158, 76);
        PanMain.Margin = new Padding(0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(756, 434);
        PanMain.TabIndex = 3;
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
        TabPanMain.ResumeLayout(false);
        PanProfile.ResumeLayout(false);
        TabPanUserProfile.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicUser).EndInit();
        PanHeader.ResumeLayout(false);
        TabPanHeader.ResumeLayout(false);
        TabPanHeader.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)PicLogo).EndInit();
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
}