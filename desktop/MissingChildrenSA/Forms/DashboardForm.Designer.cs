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
        TabPanMain.SuspendLayout();
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
        PanNavigationMenu.Location = new Point(3, 85);
        PanNavigationMenu.Name = "PanNavigationMenu";
        PanNavigationMenu.Size = new Size(152, 422);
        PanNavigationMenu.TabIndex = 0;
        // 
        // PanProfile
        // 
        PanProfile.BorderStyle = BorderStyle.FixedSingle;
        PanProfile.Dock = DockStyle.Fill;
        PanProfile.Location = new Point(3, 3);
        PanProfile.Name = "PanProfile";
        PanProfile.Size = new Size(152, 76);
        PanProfile.TabIndex = 1;
        // 
        // PanHeader
        // 
        PanHeader.BorderStyle = BorderStyle.FixedSingle;
        PanHeader.Dock = DockStyle.Fill;
        PanHeader.Location = new Point(161, 3);
        PanHeader.Name = "PanHeader";
        PanHeader.Size = new Size(750, 76);
        PanHeader.TabIndex = 2;
        // 
        // PanMain
        // 
        PanMain.BorderStyle = BorderStyle.FixedSingle;
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(161, 85);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(750, 422);
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
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TabPanMain;
    private Panel PanNavigationMenu;
    private Panel PanProfile;
    private Panel PanHeader;
    private Panel PanMain;
}