namespace MissingChildrenSA.Forms.MissingPersons;

partial class ReportMissingPersonForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportMissingPersonForm));
        PanMain = new Panel();
        MainTooltip = new ToolTip(components);
        SuspendLayout();
        // 
        // PanMain
        // 
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(0, 0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(954, 501);
        PanMain.TabIndex = 0;
        // 
        // ReportMissingPersonForm
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
        Name = "ReportMissingPersonForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Report Missing Person";
        Load += ViewUsersForm_Load;
        ResumeLayout(false);
    }

    #endregion

    private Panel PanMain;
    private ToolTip MainTooltip;
}