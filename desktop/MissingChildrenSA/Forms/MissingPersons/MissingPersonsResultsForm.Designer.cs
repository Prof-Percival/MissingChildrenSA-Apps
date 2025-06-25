namespace MissingChildrenSA.Forms.MissingPersons;

partial class MissingPersonsResultsForm
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
        TableLayoutPanelMain = new TableLayoutPanel();
        FlowLayoutPanelTiles = new FlowLayoutPanel();
        PanelPagination = new Panel();
        BtnPrev = new Button();
        BtnNext = new Button();
        TableLayoutPanelMain.SuspendLayout();
        PanelPagination.SuspendLayout();
        SuspendLayout();
        // 
        // TableLayoutPanelMain
        // 
        TableLayoutPanelMain.ColumnCount = 1;
        TableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
        TableLayoutPanelMain.Controls.Add(FlowLayoutPanelTiles, 0, 0);
        TableLayoutPanelMain.Controls.Add(PanelPagination, 0, 1);
        TableLayoutPanelMain.Dock = DockStyle.Fill;
        TableLayoutPanelMain.Location = new Point(0, 0);
        TableLayoutPanelMain.Name = "TableLayoutPanelMain";
        TableLayoutPanelMain.RowCount = 2;
        TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
        TableLayoutPanelMain.Size = new Size(934, 661);
        TableLayoutPanelMain.TabIndex = 0;
        // 
        // FlowLayoutPanelTiles
        // 
        FlowLayoutPanelTiles.AutoScroll = true;
        FlowLayoutPanelTiles.Dock = DockStyle.Fill;
        FlowLayoutPanelTiles.Location = new Point(3, 3);
        FlowLayoutPanelTiles.Name = "FlowLayoutPanelTiles";
        FlowLayoutPanelTiles.Padding = new Padding(10);
        FlowLayoutPanelTiles.Size = new Size(928, 595);
        FlowLayoutPanelTiles.TabIndex = 0;
        // 
        // PanelPagination
        // 
        PanelPagination.Controls.Add(BtnPrev);
        PanelPagination.Controls.Add(BtnNext);
        PanelPagination.Dock = DockStyle.Fill;
        PanelPagination.Location = new Point(3, 604);
        PanelPagination.Name = "PanelPagination";
        PanelPagination.Size = new Size(928, 54);
        PanelPagination.TabIndex = 1;
        // 
        // BtnPrev
        // 
        BtnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        BtnPrev.Font = new Font("Arial", 9.75F);
        BtnPrev.Location = new Point(20, 15);
        BtnPrev.Name = "BtnPrev";
        BtnPrev.Size = new Size(100, 30);
        BtnPrev.TabIndex = 0;
        BtnPrev.Text = "← Previous";
        BtnPrev.Click += BtnPrev_Click;
        // 
        // BtnNext
        // 
        BtnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnNext.Font = new Font("Arial", 9.75F);
        BtnNext.Location = new Point(812, 15);
        BtnNext.Name = "BtnNext";
        BtnNext.Size = new Size(100, 30);
        BtnNext.TabIndex = 1;
        BtnNext.Text = "Next →";
        BtnNext.Click += BtnNext_Click;
        // 
        // MissingPersonsResultsForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(934, 661);
        Controls.Add(TableLayoutPanelMain);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MissingPersonsResultsForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Missing Persons";
        FormClosing += MissingPersonsResultsForm_FormClosing;
        Load += MissingPersonsResultsForm_Load;
        TableLayoutPanelMain.ResumeLayout(false);
        PanelPagination.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TableLayoutPanelMain;
    private Panel PanelPagination;
    private FlowLayoutPanel FlowLayoutPanelTiles;
    private Button BtnNext;
    private Button BtnPrev;
}