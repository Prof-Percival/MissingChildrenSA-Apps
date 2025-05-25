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
        FlowLayoutPanelTiles = new FlowLayoutPanel();
        BtnNext = new Button();
        BtnPrev = new Button();
        SuspendLayout();
        // 
        // FlowLayoutPanelTiles
        // 
        FlowLayoutPanelTiles.AutoScroll = true;
        FlowLayoutPanelTiles.Dock = DockStyle.Fill;
        FlowLayoutPanelTiles.Location = new Point(0, 0);
        FlowLayoutPanelTiles.Name = "FlowLayoutPanelTiles";
        FlowLayoutPanelTiles.Padding = new Padding(10);
        FlowLayoutPanelTiles.Size = new Size(884, 561);
        FlowLayoutPanelTiles.TabIndex = 0;
        // 
        // BtnNext
        // 
        BtnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        BtnNext.Location = new Point(140, 10);
        BtnNext.Name = "BtnNext";
        BtnNext.Size = new Size(100, 30);
        BtnNext.TabIndex = 2;
        BtnNext.Text = "Next";
        BtnNext.Click += BtnNext_Click;
        // 
        // BtnPrev
        // 
        BtnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        BtnPrev.Location = new Point(20, 10);
        BtnPrev.Name = "BtnPrev";
        BtnPrev.Size = new Size(100, 30);
        BtnPrev.TabIndex = 1;
        BtnPrev.Text = "Previous";
        BtnPrev.Click += BtnPrev_Click;
        // 
        // MissingPersonsResultsForm
        // 
        BackColor = Color.White;
        ClientSize = new Size(884, 561);
        Controls.Add(FlowLayoutPanelTiles);
        Controls.Add(BtnPrev);
        Controls.Add(BtnNext);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MissingPersonsResultsForm";
        ShowIcon = false;
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Missing Persons";
        Load += MissingPersonsResultsForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel FlowLayoutPanelTiles;
    private Button BtnNext;
    private Button BtnPrev;
}