using MissingChildrenSA.Forms.Users;

namespace MissingChildrenSA.Forms.MissingPersons;

partial class MissingPersonsGridForm
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
        PanMain = new Panel();
        TabPanMainContainer = new TableLayoutPanel();
        TabPanHeader = new TableLayoutPanel();
        PicRefresh = new PictureBox();
        PicReportNow = new PictureBox();
        DgvMissingPersons = new DataGridView();
        MainTooltip = new ToolTip(components);
        DgvColId = new DataGridViewTextBoxColumn();
        DgvColFirstName = new DataGridViewTextBoxColumn();
        DgvColLastName = new DataGridViewTextBoxColumn();
        DgvColGender = new DataGridViewTextBoxColumn();
        DgvColProvince = new DataGridViewTextBoxColumn();
        DgvColDateWentMissing = new DataGridViewTextBoxColumn();
        DgvColStatus = new DataGridViewTextBoxColumn();
        DgvColModerationStatus = new DataGridViewTextBoxColumn();
        DgvColCreated = new DataGridViewTextBoxColumn();
        DgvColUpdated = new DataGridViewTextBoxColumn();
        DgvColLastEditedByUserId = new DataGridViewTextBoxColumn();
        DgvColEditButton = new DataGridViewButtonColumn();
        PanMain.SuspendLayout();
        TabPanMainContainer.SuspendLayout();
        TabPanHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicRefresh).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PicReportNow).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DgvMissingPersons).BeginInit();
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
        TabPanMainContainer.Controls.Add(DgvMissingPersons, 0, 1);
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
        TabPanHeader.Controls.Add(PicReportNow, 0, 0);
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
        // PicReportNow
        // 
        PicReportNow.Cursor = Cursors.Hand;
        PicReportNow.Image = Properties.Resources.add_user;
        PicReportNow.Location = new Point(3, 3);
        PicReportNow.Name = "PicReportNow";
        PicReportNow.Size = new Size(40, 33);
        PicReportNow.SizeMode = PictureBoxSizeMode.Zoom;
        PicReportNow.TabIndex = 0;
        PicReportNow.TabStop = false;
        MainTooltip.SetToolTip(PicReportNow, "Report Now");
        PicReportNow.Click += PicReportNow_Click;
        // 
        // DgvMissingPersons
        // 
        DgvMissingPersons.AllowUserToAddRows = false;
        DgvMissingPersons.AllowUserToDeleteRows = false;
        DgvMissingPersons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvMissingPersons.Columns.AddRange(new DataGridViewColumn[] { DgvColId, DgvColFirstName, DgvColLastName, DgvColGender, DgvColProvince, DgvColDateWentMissing, DgvColStatus, DgvColModerationStatus, DgvColCreated, DgvColUpdated, DgvColLastEditedByUserId, DgvColEditButton });
        DgvMissingPersons.Dock = DockStyle.Fill;
        DgvMissingPersons.GridColor = SystemColors.ControlDark;
        DgvMissingPersons.Location = new Point(3, 48);
        DgvMissingPersons.Name = "DgvMissingPersons";
        DgvMissingPersons.ReadOnly = true;
        DgvMissingPersons.RowHeadersVisible = false;
        DgvMissingPersons.Size = new Size(948, 450);
        DgvMissingPersons.TabIndex = 2;
        DgvMissingPersons.CellContentClick += DgvMissingPersons_CellContentClick;
        // 
        // DgvColId
        // 
        DgvColId.HeaderText = "Id";
        DgvColId.Name = "DgvColId";
        DgvColId.ReadOnly = true;
        DgvColId.Width = 60;
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
        // DgvColGender
        // 
        DgvColGender.HeaderText = "Gender";
        DgvColGender.Name = "DgvColGender";
        DgvColGender.ReadOnly = true;
        DgvColGender.Width = 80;
        // 
        // DgvColProvince
        // 
        DgvColProvince.HeaderText = "Province";
        DgvColProvince.Name = "DgvColProvince";
        DgvColProvince.ReadOnly = true;
        DgvColProvince.Width = 120;
        // 
        // DgvColDateWentMissing
        // 
        DgvColDateWentMissing.HeaderText = "Date Went Missing";
        DgvColDateWentMissing.Name = "DgvColDateWentMissing";
        DgvColDateWentMissing.ReadOnly = true;
        DgvColDateWentMissing.Width = 160;
        // 
        // DgvColStatus
        // 
        DgvColStatus.HeaderText = "Status";
        DgvColStatus.Name = "DgvColStatus";
        DgvColStatus.ReadOnly = true;
        // 
        // DgvColModerationStatus
        // 
        DgvColModerationStatus.HeaderText = "Moderation Status";
        DgvColModerationStatus.Name = "DgvColModerationStatus";
        DgvColModerationStatus.ReadOnly = true;
        DgvColModerationStatus.Width = 150;
        // 
        // DgvColCreated
        // 
        DgvColCreated.HeaderText = "Created";
        DgvColCreated.Name = "DgvColCreated";
        DgvColCreated.ReadOnly = true;
        DgvColCreated.Width = 130;
        // 
        // DgvColUpdated
        // 
        DgvColUpdated.HeaderText = "Updated";
        DgvColUpdated.Name = "DgvColUpdated";
        DgvColUpdated.ReadOnly = true;
        DgvColUpdated.Width = 130;
        // 
        // DgvColLastEditedByUserId
        // 
        DgvColLastEditedByUserId.HeaderText = "Edited By UserId";
        DgvColLastEditedByUserId.Name = "DgvColLastEditedByUserId";
        DgvColLastEditedByUserId.ReadOnly = true;
        // 
        // DgvColEditButton
        // 
        DgvColEditButton.HeaderText = "";
        DgvColEditButton.Name = "DgvColEditButton";
        DgvColEditButton.ReadOnly = true;
        DgvColEditButton.Text = "Edit";
        DgvColEditButton.UseColumnTextForButtonValue = true;
        // 
        // MissingPersonsGridForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(954, 501);
        Controls.Add(PanMain);
        Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MissingPersonsGridForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Missing Persons";
        Load += MissingPersonsGridForm_Load;
        PanMain.ResumeLayout(false);
        PanMain.PerformLayout();
        TabPanMainContainer.ResumeLayout(false);
        TabPanMainContainer.PerformLayout();
        TabPanHeader.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicRefresh).EndInit();
        ((System.ComponentModel.ISupportInitialize)PicReportNow).EndInit();
        ((System.ComponentModel.ISupportInitialize)DgvMissingPersons).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel PanMain;
    private TableLayoutPanel TabPanMainContainer;
    private PictureBox PicReportNow;
    private ToolTip MainTooltip;
    private TableLayoutPanel TabPanHeader;
    private PictureBox PicRefresh;
    private DataGridView DgvMissingPersons;
    private DataGridViewTextBoxColumn DgvColId;
    private DataGridViewTextBoxColumn DgvColFirstName;
    private DataGridViewTextBoxColumn DgvColLastName;
    private DataGridViewTextBoxColumn DgvColGender;
    private DataGridViewTextBoxColumn DgvColProvince;
    private DataGridViewTextBoxColumn DgvColDateWentMissing;
    private DataGridViewTextBoxColumn DgvColStatus;
    private DataGridViewTextBoxColumn DgvColModerationStatus;
    private DataGridViewTextBoxColumn DgvColCreated;
    private DataGridViewTextBoxColumn DgvColUpdated;
    private DataGridViewTextBoxColumn DgvColLastEditedByUserId;
    private DataGridViewButtonColumn DgvColEditButton;
}