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
        PanHeader = new Panel();
        PanMain = new Panel();
        PicUser = new PictureBox();
        LblUserName = new Label();
        TabPanMain.SuspendLayout();
        PanProfile.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicUser).BeginInit();
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
        TabPanMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.0848541F));
        TabPanMain.RowStyles.Add(new RowStyle(SizeType.Percent, 83.9151459F));
        TabPanMain.Size = new Size(914, 510);
        TabPanMain.TabIndex = 0;
        // 
        // PanNavigationMenu
        // 
        PanNavigationMenu.BorderStyle = BorderStyle.FixedSingle;
        PanNavigationMenu.Dock = DockStyle.Fill;
        PanNavigationMenu.Location = new Point(0, 82);
        PanNavigationMenu.Margin = new Padding(0);
        PanNavigationMenu.Name = "PanNavigationMenu";
        PanNavigationMenu.Size = new Size(158, 428);
        PanNavigationMenu.TabIndex = 0;
        // 
        // PanProfile
        // 
        PanProfile.BorderStyle = BorderStyle.FixedSingle;
        PanProfile.Controls.Add(LblUserName);
        PanProfile.Controls.Add(PicUser);
        PanProfile.Dock = DockStyle.Fill;
        PanProfile.Location = new Point(0, 0);
        PanProfile.Margin = new Padding(0);
        PanProfile.Name = "PanProfile";
        PanProfile.Size = new Size(158, 82);
        PanProfile.TabIndex = 1;
        // 
        // PanHeader
        // 
        PanHeader.BorderStyle = BorderStyle.FixedSingle;
        PanHeader.Dock = DockStyle.Fill;
        PanHeader.Location = new Point(158, 0);
        PanHeader.Margin = new Padding(0);
        PanHeader.Name = "PanHeader";
        PanHeader.Size = new Size(756, 82);
        PanHeader.TabIndex = 2;
        // 
        // PanMain
        // 
        PanMain.BorderStyle = BorderStyle.FixedSingle;
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(158, 82);
        PanMain.Margin = new Padding(0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(756, 428);
        PanMain.TabIndex = 3;
        // 
        // PicUser
        // 
        PicUser.Image = Properties.Resources.user;
        PicUser.Location = new Point(52, 0);
        PicUser.Name = "PicUser";
        PicUser.Size = new Size(42, 42);
        PicUser.SizeMode = PictureBoxSizeMode.StretchImage;
        PicUser.TabIndex = 0;
        PicUser.TabStop = false;
        // 
        // LblUserName
        // 
        LblUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        LblUserName.AutoEllipsis = true;
        LblUserName.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblUserName.Location = new Point(3, 45);
        LblUserName.Name = "LblUserName";
        LblUserName.RightToLeft = RightToLeft.No;
        LblUserName.Size = new Size(151, 14);
        LblUserName.TabIndex = 0;
        LblUserName.Text = "Phadima Percival Maredi";
        LblUserName.TextAlign = ContentAlignment.MiddleCenter;
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
        ((System.ComponentModel.ISupportInitialize)PicUser).EndInit();
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
}