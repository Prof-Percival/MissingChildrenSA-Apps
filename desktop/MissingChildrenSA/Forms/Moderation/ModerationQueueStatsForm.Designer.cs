namespace MissingChildrenSA.Forms.Moderation;

partial class ModerationQueueStatsForm
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
        TabPanQueueStats = new TableLayoutPanel();
        PanUnmoderated = new Panel();
        LblUnmoderatedTitle = new Label();
        LblUnmoderated = new Label();
        PanInModeration = new Panel();
        LblInModeration = new Label();
        LblInModerationTitle = new Label();
        PanFailed = new Panel();
        LblFailed = new Label();
        LblFailedTitle = new Label();
        PanApproved = new Panel();
        LblApproved = new Label();
        LblApprovedTitle = new Label();
        TabPanQueueStats.SuspendLayout();
        PanUnmoderated.SuspendLayout();
        PanInModeration.SuspendLayout();
        PanFailed.SuspendLayout();
        PanApproved.SuspendLayout();
        SuspendLayout();
        // 
        // TabPanQueueStats
        // 
        TabPanQueueStats.ColumnCount = 2;
        TabPanQueueStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanQueueStats.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanQueueStats.Controls.Add(PanApproved, 1, 1);
        TabPanQueueStats.Controls.Add(PanFailed, 0, 1);
        TabPanQueueStats.Controls.Add(PanInModeration, 1, 0);
        TabPanQueueStats.Controls.Add(PanUnmoderated, 0, 0);
        TabPanQueueStats.Dock = DockStyle.Fill;
        TabPanQueueStats.Location = new Point(0, 0);
        TabPanQueueStats.Name = "TabPanQueueStats";
        TabPanQueueStats.RowCount = 2;
        TabPanQueueStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanQueueStats.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanQueueStats.Size = new Size(484, 461);
        TabPanQueueStats.TabIndex = 0;
        // 
        // PanUnmoderated
        // 
        PanUnmoderated.Controls.Add(LblUnmoderated);
        PanUnmoderated.Controls.Add(LblUnmoderatedTitle);
        PanUnmoderated.Dock = DockStyle.Fill;
        PanUnmoderated.Location = new Point(3, 3);
        PanUnmoderated.Name = "PanUnmoderated";
        PanUnmoderated.Size = new Size(236, 224);
        PanUnmoderated.TabIndex = 0;
        // 
        // LblUnmoderatedTitle
        // 
        LblUnmoderatedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblUnmoderatedTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblUnmoderatedTitle.Location = new Point(3, 15);
        LblUnmoderatedTitle.Name = "LblUnmoderatedTitle";
        LblUnmoderatedTitle.Size = new Size(230, 29);
        LblUnmoderatedTitle.TabIndex = 0;
        LblUnmoderatedTitle.Text = "Unmoderated";
        LblUnmoderatedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblUnmoderated
        // 
        LblUnmoderated.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblUnmoderated.AutoEllipsis = true;
        LblUnmoderated.Font = new Font("Arial", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblUnmoderated.Location = new Point(3, 57);
        LblUnmoderated.Name = "LblUnmoderated";
        LblUnmoderated.Size = new Size(230, 134);
        LblUnmoderated.TabIndex = 1;
        LblUnmoderated.Text = "0";
        LblUnmoderated.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanInModeration
        // 
        PanInModeration.Controls.Add(LblInModeration);
        PanInModeration.Controls.Add(LblInModerationTitle);
        PanInModeration.Dock = DockStyle.Fill;
        PanInModeration.Location = new Point(245, 3);
        PanInModeration.Name = "PanInModeration";
        PanInModeration.Size = new Size(236, 224);
        PanInModeration.TabIndex = 1;
        // 
        // LblInModeration
        // 
        LblInModeration.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblInModeration.AutoEllipsis = true;
        LblInModeration.Font = new Font("Arial", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblInModeration.Location = new Point(3, 57);
        LblInModeration.Name = "LblInModeration";
        LblInModeration.Size = new Size(230, 134);
        LblInModeration.TabIndex = 1;
        LblInModeration.Text = "0";
        LblInModeration.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblInModerationTitle
        // 
        LblInModerationTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblInModerationTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblInModerationTitle.Location = new Point(3, 15);
        LblInModerationTitle.Name = "LblInModerationTitle";
        LblInModerationTitle.Size = new Size(230, 29);
        LblInModerationTitle.TabIndex = 0;
        LblInModerationTitle.Text = "In Moderation";
        LblInModerationTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanFailed
        // 
        PanFailed.Controls.Add(LblFailed);
        PanFailed.Controls.Add(LblFailedTitle);
        PanFailed.Dock = DockStyle.Fill;
        PanFailed.Location = new Point(3, 233);
        PanFailed.Name = "PanFailed";
        PanFailed.Size = new Size(236, 225);
        PanFailed.TabIndex = 2;
        // 
        // LblFailed
        // 
        LblFailed.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblFailed.AutoEllipsis = true;
        LblFailed.Font = new Font("Arial", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblFailed.Location = new Point(3, 57);
        LblFailed.Name = "LblFailed";
        LblFailed.Size = new Size(230, 134);
        LblFailed.TabIndex = 1;
        LblFailed.Text = "0";
        LblFailed.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblFailedTitle
        // 
        LblFailedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblFailedTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblFailedTitle.Location = new Point(3, 15);
        LblFailedTitle.Name = "LblFailedTitle";
        LblFailedTitle.Size = new Size(230, 29);
        LblFailedTitle.TabIndex = 0;
        LblFailedTitle.Text = "Failed";
        LblFailedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // PanApproved
        // 
        PanApproved.Controls.Add(LblApproved);
        PanApproved.Controls.Add(LblApprovedTitle);
        PanApproved.Dock = DockStyle.Fill;
        PanApproved.Location = new Point(245, 233);
        PanApproved.Name = "PanApproved";
        PanApproved.Size = new Size(236, 225);
        PanApproved.TabIndex = 3;
        // 
        // LblApproved
        // 
        LblApproved.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblApproved.AutoEllipsis = true;
        LblApproved.Font = new Font("Arial", 63.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblApproved.Location = new Point(3, 57);
        LblApproved.Name = "LblApproved";
        LblApproved.Size = new Size(230, 134);
        LblApproved.TabIndex = 1;
        LblApproved.Text = "0";
        LblApproved.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // LblApprovedTitle
        // 
        LblApprovedTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        LblApprovedTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblApprovedTitle.Location = new Point(3, 15);
        LblApprovedTitle.Name = "LblApprovedTitle";
        LblApprovedTitle.Size = new Size(230, 29);
        LblApprovedTitle.TabIndex = 0;
        LblApprovedTitle.Text = "Approved";
        LblApprovedTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // ModerationQueueStatsForm
        // 
        AutoScaleDimensions = new SizeF(9F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(484, 461);
        Controls.Add(TabPanQueueStats);
        Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4, 4, 4, 4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ModerationQueueStatsForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Moderation Queue Stats";
        TabPanQueueStats.ResumeLayout(false);
        PanUnmoderated.ResumeLayout(false);
        PanInModeration.ResumeLayout(false);
        PanFailed.ResumeLayout(false);
        PanApproved.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TabPanQueueStats;
    private Panel PanUnmoderated;
    private Label LblUnmoderatedTitle;
    private Label LblUnmoderated;
    private Panel PanApproved;
    private Label LblApproved;
    private Label LblApprovedTitle;
    private Panel PanFailed;
    private Label LblFailed;
    private Label LblFailedTitle;
    private Panel PanInModeration;
    private Label LblInModeration;
    private Label LblInModerationTitle;
}