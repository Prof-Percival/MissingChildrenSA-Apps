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
        GrpPersonalDetails = new GroupBox();
        PanPersonalDetails = new Panel();
        CmbProvince = new ComboBox();
        LblRequired6 = new Label();
        LblProvince = new Label();
        CmbRace = new ComboBox();
        LblRequired5 = new Label();
        LblRace = new Label();
        CmbGender = new ComboBox();
        DtpDateOfBirth = new DateTimePicker();
        LblDateOfBirth = new Label();
        LblRequired3 = new Label();
        LblRequired4 = new Label();
        LblGender = new Label();
        LblName = new Label();
        TxtSurname = new TextBox();
        LblRequired = new Label();
        LblRequired2 = new Label();
        TxtName = new TextBox();
        LblSurname = new Label();
        MainTooltip = new ToolTip(components);
        PanMain.SuspendLayout();
        GrpPersonalDetails.SuspendLayout();
        PanPersonalDetails.SuspendLayout();
        SuspendLayout();
        // 
        // PanMain
        // 
        PanMain.AutoScroll = true;
        PanMain.AutoSize = true;
        PanMain.Controls.Add(GrpPersonalDetails);
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(0, 0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(954, 501);
        PanMain.TabIndex = 0;
        // 
        // GrpPersonalDetails
        // 
        GrpPersonalDetails.AutoSize = true;
        GrpPersonalDetails.Controls.Add(PanPersonalDetails);
        GrpPersonalDetails.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpPersonalDetails.Location = new Point(12, 12);
        GrpPersonalDetails.Name = "GrpPersonalDetails";
        GrpPersonalDetails.Size = new Size(392, 246);
        GrpPersonalDetails.TabIndex = 6;
        GrpPersonalDetails.TabStop = false;
        GrpPersonalDetails.Text = "Personal Details";
        // 
        // PanPersonalDetails
        // 
        PanPersonalDetails.Controls.Add(CmbProvince);
        PanPersonalDetails.Controls.Add(LblRequired6);
        PanPersonalDetails.Controls.Add(LblProvince);
        PanPersonalDetails.Controls.Add(CmbRace);
        PanPersonalDetails.Controls.Add(LblRequired5);
        PanPersonalDetails.Controls.Add(LblRace);
        PanPersonalDetails.Controls.Add(CmbGender);
        PanPersonalDetails.Controls.Add(DtpDateOfBirth);
        PanPersonalDetails.Controls.Add(LblDateOfBirth);
        PanPersonalDetails.Controls.Add(LblRequired3);
        PanPersonalDetails.Controls.Add(LblRequired4);
        PanPersonalDetails.Controls.Add(LblGender);
        PanPersonalDetails.Controls.Add(LblName);
        PanPersonalDetails.Controls.Add(TxtSurname);
        PanPersonalDetails.Controls.Add(LblRequired);
        PanPersonalDetails.Controls.Add(LblRequired2);
        PanPersonalDetails.Controls.Add(TxtName);
        PanPersonalDetails.Controls.Add(LblSurname);
        PanPersonalDetails.Dock = DockStyle.Fill;
        PanPersonalDetails.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanPersonalDetails.Location = new Point(3, 25);
        PanPersonalDetails.Name = "PanPersonalDetails";
        PanPersonalDetails.Size = new Size(386, 218);
        PanPersonalDetails.TabIndex = 7;
        // 
        // CmbProvince
        // 
        CmbProvince.FormattingEnabled = true;
        CmbProvince.Location = new Point(200, 139);
        CmbProvince.Name = "CmbProvince";
        CmbProvince.Size = new Size(176, 25);
        CmbProvince.TabIndex = 18;
        // 
        // LblRequired6
        // 
        LblRequired6.AutoSize = true;
        LblRequired6.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired6.ForeColor = Color.Red;
        LblRequired6.Location = new Point(259, 117);
        LblRequired6.Margin = new Padding(0);
        LblRequired6.Name = "LblRequired6";
        LblRequired6.Size = new Size(14, 18);
        LblRequired6.TabIndex = 17;
        LblRequired6.Text = "*";
        // 
        // LblProvince
        // 
        LblProvince.AutoSize = true;
        LblProvince.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblProvince.Location = new Point(198, 116);
        LblProvince.Margin = new Padding(0);
        LblProvince.Name = "LblProvince";
        LblProvince.Size = new Size(63, 20);
        LblProvince.TabIndex = 16;
        LblProvince.Text = "Province";
        LblProvince.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CmbRace
        // 
        CmbRace.FormattingEnabled = true;
        CmbRace.Location = new Point(7, 139);
        CmbRace.Name = "CmbRace";
        CmbRace.Size = new Size(176, 25);
        CmbRace.TabIndex = 15;
        // 
        // LblRequired5
        // 
        LblRequired5.AutoSize = true;
        LblRequired5.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired5.ForeColor = Color.Red;
        LblRequired5.Location = new Point(40, 117);
        LblRequired5.Margin = new Padding(0);
        LblRequired5.Name = "LblRequired5";
        LblRequired5.Size = new Size(14, 18);
        LblRequired5.TabIndex = 14;
        LblRequired5.Text = "*";
        // 
        // LblRace
        // 
        LblRace.AutoSize = true;
        LblRace.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRace.Location = new Point(4, 116);
        LblRace.Margin = new Padding(0);
        LblRace.Name = "LblRace";
        LblRace.Size = new Size(39, 20);
        LblRace.TabIndex = 13;
        LblRace.Text = "Race";
        LblRace.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // CmbGender
        // 
        CmbGender.FormattingEnabled = true;
        CmbGender.Location = new Point(200, 84);
        CmbGender.Name = "CmbGender";
        CmbGender.Size = new Size(176, 25);
        CmbGender.TabIndex = 12;
        // 
        // DtpDateOfBirth
        // 
        DtpDateOfBirth.CustomFormat = "dd/MM/yyyy";
        DtpDateOfBirth.Format = DateTimePickerFormat.Short;
        DtpDateOfBirth.Location = new Point(7, 83);
        DtpDateOfBirth.MaxDate = new DateTime(2025, 5, 7, 0, 0, 0, 0);
        DtpDateOfBirth.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        DtpDateOfBirth.Name = "DtpDateOfBirth";
        DtpDateOfBirth.Size = new Size(174, 25);
        DtpDateOfBirth.TabIndex = 11;
        DtpDateOfBirth.Value = new DateTime(2025, 5, 7, 0, 0, 0, 0);
        // 
        // LblDateOfBirth
        // 
        LblDateOfBirth.AutoSize = true;
        LblDateOfBirth.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblDateOfBirth.Location = new Point(3, 60);
        LblDateOfBirth.Margin = new Padding(0);
        LblDateOfBirth.Name = "LblDateOfBirth";
        LblDateOfBirth.Size = new Size(84, 20);
        LblDateOfBirth.TabIndex = 6;
        LblDateOfBirth.Text = "Date of Birth";
        LblDateOfBirth.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblRequired3
        // 
        LblRequired3.AutoSize = true;
        LblRequired3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired3.ForeColor = Color.Red;
        LblRequired3.Location = new Point(86, 61);
        LblRequired3.Margin = new Padding(0);
        LblRequired3.Name = "LblRequired3";
        LblRequired3.Size = new Size(14, 18);
        LblRequired3.TabIndex = 7;
        LblRequired3.Text = "*";
        // 
        // LblRequired4
        // 
        LblRequired4.AutoSize = true;
        LblRequired4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired4.ForeColor = Color.Red;
        LblRequired4.Location = new Point(251, 62);
        LblRequired4.Margin = new Padding(0);
        LblRequired4.Name = "LblRequired4";
        LblRequired4.Size = new Size(14, 18);
        LblRequired4.TabIndex = 10;
        LblRequired4.Text = "*";
        // 
        // LblGender
        // 
        LblGender.AutoSize = true;
        LblGender.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblGender.Location = new Point(198, 61);
        LblGender.Margin = new Padding(0);
        LblGender.Name = "LblGender";
        LblGender.Size = new Size(54, 20);
        LblGender.TabIndex = 9;
        LblGender.Text = "Gender";
        LblGender.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblName
        // 
        LblName.AutoSize = true;
        LblName.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblName.Location = new Point(3, 4);
        LblName.Margin = new Padding(0);
        LblName.Name = "LblName";
        LblName.Size = new Size(43, 20);
        LblName.TabIndex = 0;
        LblName.Text = "Name";
        LblName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TxtSurname
        // 
        TxtSurname.Location = new Point(200, 26);
        TxtSurname.Name = "TxtSurname";
        TxtSurname.Size = new Size(176, 25);
        TxtSurname.TabIndex = 5;
        // 
        // LblRequired
        // 
        LblRequired.AutoSize = true;
        LblRequired.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired.ForeColor = Color.Red;
        LblRequired.Location = new Point(44, 5);
        LblRequired.Margin = new Padding(0);
        LblRequired.Name = "LblRequired";
        LblRequired.Size = new Size(14, 18);
        LblRequired.TabIndex = 1;
        LblRequired.Text = "*";
        // 
        // LblRequired2
        // 
        LblRequired2.AutoSize = true;
        LblRequired2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired2.ForeColor = Color.Red;
        LblRequired2.Location = new Point(254, 6);
        LblRequired2.Margin = new Padding(0);
        LblRequired2.Name = "LblRequired2";
        LblRequired2.Size = new Size(14, 18);
        LblRequired2.TabIndex = 4;
        LblRequired2.Text = "*";
        // 
        // TxtName
        // 
        TxtName.Location = new Point(7, 26);
        TxtName.Name = "TxtName";
        TxtName.Size = new Size(176, 25);
        TxtName.TabIndex = 2;
        // 
        // LblSurname
        // 
        LblSurname.AutoSize = true;
        LblSurname.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblSurname.Location = new Point(196, 5);
        LblSurname.Margin = new Padding(0);
        LblSurname.Name = "LblSurname";
        LblSurname.Size = new Size(63, 20);
        LblSurname.TabIndex = 3;
        LblSurname.Text = "Surname";
        LblSurname.TextAlign = ContentAlignment.MiddleLeft;
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
        Load += ReportMissingPersonForm_Load;
        PanMain.ResumeLayout(false);
        PanMain.PerformLayout();
        GrpPersonalDetails.ResumeLayout(false);
        PanPersonalDetails.ResumeLayout(false);
        PanPersonalDetails.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel PanMain;
    private ToolTip MainTooltip;
    private Label LblName;
    private Label LblRequired;
    private TextBox TxtName;
    private TextBox TxtSurname;
    private Label LblRequired2;
    private Label LblSurname;
    private GroupBox GrpPersonalDetails;
    private Panel PanPersonalDetails;
    private Label LblDateOfBirth;
    private Label LblRequired3;
    private Label LblRequired4;
    private Label LblGender;
    private DateTimePicker DtpDateOfBirth;
    private ComboBox CmbGender;
    private ComboBox CmbRace;
    private Label LblRequired5;
    private Label LblRace;
    private ComboBox CmbProvince;
    private Label LblRequired6;
    private Label LblProvince;
}