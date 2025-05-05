namespace MissingChildrenSA.Forms.Users;

partial class ViewUsersForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUsersForm));
        PanMain = new Panel();
        TabPanMainContainer = new TableLayoutPanel();
        TabPanHeader = new TableLayoutPanel();
        PicRefresh = new PictureBox();
        PicAddUser = new PictureBox();
        DgvUsers = new DataGridView();
        DgvColId = new DataGridViewTextBoxColumn();
        DgvColUsername = new DataGridViewTextBoxColumn();
        DgvColFirstName = new DataGridViewTextBoxColumn();
        DgvColLastName = new DataGridViewTextBoxColumn();
        DgvColRole = new DataGridViewTextBoxColumn();
        DgvColCreated = new DataGridViewTextBoxColumn();
        DgvColUpdated = new DataGridViewTextBoxColumn();
        DgvColEditButton = new DataGridViewButtonColumn();
        DgvColDeleteButton = new DataGridViewButtonColumn();
        MainTooltip = new ToolTip(components);
        PanMain.SuspendLayout();
        TabPanMainContainer.SuspendLayout();
        TabPanHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicRefresh).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PicAddUser).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DgvUsers).BeginInit();
        SuspendLayout();
        // 
        // PanMain
        // 
        PanMain.Controls.Add(TabPanMainContainer);
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(0, 0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(954, 501);
        PanMain.TabIndex = 0;
        // 
        // TabPanMainContainer
        // 
        TabPanMainContainer.AutoSize = true;
        TabPanMainContainer.ColumnCount = 1;
        TabPanMainContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanMainContainer.Controls.Add(TabPanHeader, 0, 0);
        TabPanMainContainer.Controls.Add(DgvUsers, 0, 1);
        TabPanMainContainer.Dock = DockStyle.Fill;
        TabPanMainContainer.Location = new Point(0, 0);
        TabPanMainContainer.Name = "TabPanMainContainer";
        TabPanMainContainer.RowCount = 2;
        TabPanMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
        TabPanMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 91F));
        TabPanMainContainer.Size = new Size(954, 501);
        TabPanMainContainer.TabIndex = 0;
        // 
        // TabPanHeader
        // 
        TabPanHeader.AutoSize = true;
        TabPanHeader.ColumnCount = 2;
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanHeader.Controls.Add(PicRefresh, 1, 0);
        TabPanHeader.Controls.Add(PicAddUser, 0, 0);
        TabPanHeader.Location = new Point(3, 3);
        TabPanHeader.Name = "TabPanHeader";
        TabPanHeader.RowCount = 1;
        TabPanHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanHeader.Size = new Size(106, 39);
        TabPanHeader.TabIndex = 1;
        // 
        // PicRefresh
        // 
        PicRefresh.Cursor = Cursors.Hand;
        PicRefresh.Image = Properties.Resources.refresh;
        PicRefresh.Location = new Point(63, 3);
        PicRefresh.Margin = new Padding(10, 3, 3, 3);
        PicRefresh.Name = "PicRefresh";
        PicRefresh.Size = new Size(40, 33);
        PicRefresh.SizeMode = PictureBoxSizeMode.Zoom;
        PicRefresh.TabIndex = 1;
        PicRefresh.TabStop = false;
        MainTooltip.SetToolTip(PicRefresh, "Refresh");
        PicRefresh.Click += PicRefresh_Click;
        // 
        // PicAddUser
        // 
        PicAddUser.Cursor = Cursors.Hand;
        PicAddUser.Image = Properties.Resources.add_user;
        PicAddUser.Location = new Point(3, 3);
        PicAddUser.Name = "PicAddUser";
        PicAddUser.Size = new Size(40, 33);
        PicAddUser.SizeMode = PictureBoxSizeMode.Zoom;
        PicAddUser.TabIndex = 0;
        PicAddUser.TabStop = false;
        MainTooltip.SetToolTip(PicAddUser, "Add User");
        PicAddUser.Click += PicAddUser_Click;
        // 
        // DgvUsers
        // 
        DgvUsers.AllowUserToAddRows = false;
        DgvUsers.AllowUserToDeleteRows = false;
        DgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvUsers.Columns.AddRange(new DataGridViewColumn[] { DgvColId, DgvColUsername, DgvColFirstName, DgvColLastName, DgvColRole, DgvColCreated, DgvColUpdated, DgvColEditButton, DgvColDeleteButton });
        DgvUsers.Dock = DockStyle.Fill;
        DgvUsers.GridColor = SystemColors.ControlDark;
        DgvUsers.Location = new Point(3, 48);
        DgvUsers.Name = "DgvUsers";
        DgvUsers.ReadOnly = true;
        DgvUsers.RowHeadersVisible = false;
        DgvUsers.Size = new Size(948, 450);
        DgvUsers.TabIndex = 2;
        DgvUsers.CellContentClick += DgvUsers_CellContentClick;
        // 
        // DgvColId
        // 
        DgvColId.HeaderText = "Id";
        DgvColId.Name = "DgvColId";
        DgvColId.ReadOnly = true;
        DgvColId.Width = 60;
        // 
        // DgvColUsername
        // 
        DgvColUsername.HeaderText = "Username";
        DgvColUsername.Name = "DgvColUsername";
        DgvColUsername.ReadOnly = true;
        DgvColUsername.Width = 200;
        // 
        // DgvColFirstName
        // 
        DgvColFirstName.HeaderText = "First Name";
        DgvColFirstName.Name = "DgvColFirstName";
        DgvColFirstName.ReadOnly = true;
        DgvColFirstName.Width = 150;
        // 
        // DgvColLastName
        // 
        DgvColLastName.HeaderText = "Last Name";
        DgvColLastName.Name = "DgvColLastName";
        DgvColLastName.ReadOnly = true;
        DgvColLastName.Width = 150;
        // 
        // DgvColRole
        // 
        DgvColRole.HeaderText = "Role";
        DgvColRole.Name = "DgvColRole";
        DgvColRole.ReadOnly = true;
        // 
        // DgvColCreated
        // 
        DgvColCreated.HeaderText = "Created";
        DgvColCreated.Name = "DgvColCreated";
        DgvColCreated.ReadOnly = true;
        DgvColCreated.Width = 120;
        // 
        // DgvColUpdated
        // 
        DgvColUpdated.HeaderText = "Updated";
        DgvColUpdated.Name = "DgvColUpdated";
        DgvColUpdated.ReadOnly = true;
        DgvColUpdated.Width = 120;
        // 
        // DgvColEditButton
        // 
        DgvColEditButton.HeaderText = "";
        DgvColEditButton.Name = "DgvColEditButton";
        DgvColEditButton.ReadOnly = true;
        DgvColEditButton.Text = "Edit";
        DgvColEditButton.UseColumnTextForButtonValue = true;
        // 
        // DgvColDeleteButton
        // 
        DgvColDeleteButton.HeaderText = "";
        DgvColDeleteButton.Name = "DgvColDeleteButton";
        DgvColDeleteButton.ReadOnly = true;
        DgvColDeleteButton.Text = "Delete";
        DgvColDeleteButton.UseColumnTextForButtonValue = true;
        // 
        // ViewUsersForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(954, 501);
        Controls.Add(PanMain);
        Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ViewUsersForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Users";
        Load += ViewUsersForm_Load;
        PanMain.ResumeLayout(false);
        PanMain.PerformLayout();
        TabPanMainContainer.ResumeLayout(false);
        TabPanMainContainer.PerformLayout();
        TabPanHeader.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicRefresh).EndInit();
        ((System.ComponentModel.ISupportInitialize)PicAddUser).EndInit();
        ((System.ComponentModel.ISupportInitialize)DgvUsers).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel PanMain;
    private TableLayoutPanel TabPanMainContainer;
    private PictureBox PicAddUser;
    private ToolTip MainTooltip;
    private TableLayoutPanel TabPanHeader;
    private PictureBox PicRefresh;
    private DataGridView DgvUsers;
    private DataGridViewTextBoxColumn DgvColId;
    private DataGridViewTextBoxColumn DgvColUsername;
    private DataGridViewTextBoxColumn DgvColFirstName;
    private DataGridViewTextBoxColumn DgvColLastName;
    private DataGridViewTextBoxColumn DgvColRole;
    private DataGridViewTextBoxColumn DgvColCreated;
    private DataGridViewTextBoxColumn DgvColUpdated;
    private DataGridViewButtonColumn DgvColEditButton;
    private DataGridViewButtonColumn DgvColDeleteButton;
}