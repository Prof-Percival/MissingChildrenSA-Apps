namespace MissingChildrenSA.Forms.Moderation;

partial class ModerationQueueForm
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
        DgvModerationQueue = new DataGridView();
        MainTooltip = new ToolTip(components);
        DgvColId = new DataGridViewTextBoxColumn();
        DgvColCreated = new DataGridViewTextBoxColumn();
        DgvColUpdated = new DataGridViewTextBoxColumn();
        DgvColModeratedByUserId = new DataGridViewTextBoxColumn();
        DgvColMissingPersonId = new DataGridViewTextBoxColumn();
        DgvColModerationStatus = new DataGridViewTextBoxColumn();
        DgvColModerationStatusReason = new DataGridViewTextBoxColumn();
        DgvColViewButton = new DataGridViewButtonColumn();
        PanMain.SuspendLayout();
        TabPanMainContainer.SuspendLayout();
        TabPanHeader.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicRefresh).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DgvModerationQueue).BeginInit();
        SuspendLayout();
        // 
        // PanMain
        // 
        PanMain.Controls.Add(TabPanMainContainer);
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(0, 0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(1060, 501);
        PanMain.TabIndex = 0;
        // 
        // TabPanMainContainer
        // 
        TabPanMainContainer.AutoSize = true;
        TabPanMainContainer.ColumnCount = 1;
        TabPanMainContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanMainContainer.Controls.Add(TabPanHeader, 0, 0);
        TabPanMainContainer.Controls.Add(DgvModerationQueue, 0, 1);
        TabPanMainContainer.Dock = DockStyle.Fill;
        TabPanMainContainer.Location = new Point(0, 0);
        TabPanMainContainer.Name = "TabPanMainContainer";
        TabPanMainContainer.RowCount = 2;
        TabPanMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 9F));
        TabPanMainContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 91F));
        TabPanMainContainer.Size = new Size(1060, 501);
        TabPanMainContainer.TabIndex = 0;
        // 
        // TabPanHeader
        // 
        TabPanHeader.AutoSize = true;
        TabPanHeader.ColumnCount = 1;
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanHeader.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        TabPanHeader.Controls.Add(PicRefresh, 0, 0);
        TabPanHeader.Location = new Point(3, 3);
        TabPanHeader.Name = "TabPanHeader";
        TabPanHeader.RowCount = 1;
        TabPanHeader.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TabPanHeader.Size = new Size(53, 39);
        TabPanHeader.TabIndex = 1;
        // 
        // PicRefresh
        // 
        PicRefresh.Cursor = Cursors.Hand;
        PicRefresh.Image = Properties.Resources.refresh;
        PicRefresh.Location = new Point(10, 3);
        PicRefresh.Margin = new Padding(10, 3, 3, 3);
        PicRefresh.Name = "PicRefresh";
        PicRefresh.Size = new Size(40, 33);
        PicRefresh.SizeMode = PictureBoxSizeMode.Zoom;
        PicRefresh.TabIndex = 1;
        PicRefresh.TabStop = false;
        MainTooltip.SetToolTip(PicRefresh, "Refresh");
        PicRefresh.Click += PicRefresh_Click;
        // 
        // DgvModerationQueue
        // 
        DgvModerationQueue.AllowUserToAddRows = false;
        DgvModerationQueue.AllowUserToDeleteRows = false;
        DgvModerationQueue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DgvModerationQueue.Columns.AddRange(new DataGridViewColumn[] { DgvColId, DgvColCreated, DgvColUpdated, DgvColModeratedByUserId, DgvColMissingPersonId, DgvColModerationStatus, DgvColModerationStatusReason, DgvColViewButton });
        DgvModerationQueue.Dock = DockStyle.Fill;
        DgvModerationQueue.GridColor = SystemColors.ControlDark;
        DgvModerationQueue.Location = new Point(3, 48);
        DgvModerationQueue.Name = "DgvModerationQueue";
        DgvModerationQueue.ReadOnly = true;
        DgvModerationQueue.RowHeadersVisible = false;
        DgvModerationQueue.Size = new Size(1054, 450);
        DgvModerationQueue.TabIndex = 2;
        DgvModerationQueue.CellContentClick += DgvModerationQueue_CellContentClick;
        // 
        // DgvColId
        // 
        DgvColId.HeaderText = "Id";
        DgvColId.Name = "DgvColId";
        DgvColId.ReadOnly = true;
        DgvColId.Width = 60;
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
        // DgvColModeratedByUserId
        // 
        DgvColModeratedByUserId.HeaderText = "Moderated By UserId";
        DgvColModeratedByUserId.Name = "DgvColModeratedByUserId";
        DgvColModeratedByUserId.ReadOnly = true;
        // 
        // DgvColMissingPersonId
        // 
        DgvColMissingPersonId.HeaderText = "Missing Person Id";
        DgvColMissingPersonId.Name = "DgvColMissingPersonId";
        DgvColMissingPersonId.ReadOnly = true;
        DgvColMissingPersonId.Width = 80;
        // 
        // DgvColModerationStatus
        // 
        DgvColModerationStatus.HeaderText = "Moderation Status";
        DgvColModerationStatus.Name = "DgvColModerationStatus";
        DgvColModerationStatus.ReadOnly = true;
        DgvColModerationStatus.Width = 150;
        // 
        // DgvColModerationStatusReason
        // 
        DgvColModerationStatusReason.HeaderText = "Moderation Status Reason";
        DgvColModerationStatusReason.Name = "DgvColModerationStatusReason";
        DgvColModerationStatusReason.ReadOnly = true;
        DgvColModerationStatusReason.Width = 350;
        // 
        // DgvColViewButton
        // 
        DgvColViewButton.HeaderText = "";
        DgvColViewButton.Name = "DgvColViewButton";
        DgvColViewButton.ReadOnly = true;
        DgvColViewButton.Text = "View";
        DgvColViewButton.UseColumnTextForButtonValue = true;
        // 
        // ModerationQueueForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1060, 501);
        Controls.Add(PanMain);
        Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ModerationQueueForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Moderation Queue";
        Load += ModerationQueueForm_Load;
        PanMain.ResumeLayout(false);
        PanMain.PerformLayout();
        TabPanMainContainer.ResumeLayout(false);
        TabPanMainContainer.PerformLayout();
        TabPanHeader.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicRefresh).EndInit();
        ((System.ComponentModel.ISupportInitialize)DgvModerationQueue).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel PanMain;
    private TableLayoutPanel TabPanMainContainer;
    private ToolTip MainTooltip;
    private TableLayoutPanel TabPanHeader;
    private PictureBox PicRefresh;
    private DataGridView DgvModerationQueue;
    private DataGridViewTextBoxColumn DgvColId;
    private DataGridViewTextBoxColumn DgvColCreated;
    private DataGridViewTextBoxColumn DgvColUpdated;
    private DataGridViewTextBoxColumn DgvColModeratedByUserId;
    private DataGridViewTextBoxColumn DgvColMissingPersonId;
    private DataGridViewTextBoxColumn DgvColModerationStatus;
    private DataGridViewTextBoxColumn DgvColModerationStatusReason;
    private DataGridViewButtonColumn DgvColViewButton;
}