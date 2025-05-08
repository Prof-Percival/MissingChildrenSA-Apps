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
        GrpDisappearanceDetails = new GroupBox();
        PanDisappearanceDetails = new Panel();
        LblDateWentMissing = new Label();
        TxtLocationLastSeen = new TextBox();
        DtpDateWentMissing = new DateTimePicker();
        LblLastSeenWearing = new Label();
        LblRequired12 = new Label();
        TxtLastSeenWearing = new TextBox();
        LblLocationLastSeen = new Label();
        GrpPhysicalDescription = new GroupBox();
        PanPhysicalDescription = new Panel();
        NupWeight = new NumericUpDown();
        NupHeight = new NumericUpDown();
        TxtMarksTattoos = new TextBox();
        TxtEyeColour = new TextBox();
        LblMarksTattoos = new Label();
        LblRequired11 = new Label();
        LblWeight = new Label();
        LblEyeColour = new Label();
        LblRequired9 = new Label();
        LblRequired10 = new Label();
        LblHeight = new Label();
        LblHairColour = new Label();
        TxtHairLengthOrStyle = new TextBox();
        LblRequired7 = new Label();
        LblRequired8 = new Label();
        TxtHairColour = new TextBox();
        LblHairLengthOrStyle = new Label();
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
        GrpPoliceReport = new GroupBox();
        PanPoliceReport = new Panel();
        LblInvestigatingOfficer = new Label();
        LblRequired15 = new Label();
        LblRequired16 = new Label();
        LblInvestigatingOfficerContactNumber = new Label();
        LblPoliceStation = new Label();
        TxtCaseNumber = new TextBox();
        LblRequired13 = new Label();
        LblRequired14 = new Label();
        TxtPoliceStation = new TextBox();
        LblCaseNumber = new Label();
        TxtInvestigatingOfficer = new TextBox();
        TxtInvestigatingOfficerContactNumber = new TextBox();
        PanMain.SuspendLayout();
        GrpDisappearanceDetails.SuspendLayout();
        PanDisappearanceDetails.SuspendLayout();
        GrpPhysicalDescription.SuspendLayout();
        PanPhysicalDescription.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)NupWeight).BeginInit();
        ((System.ComponentModel.ISupportInitialize)NupHeight).BeginInit();
        GrpPersonalDetails.SuspendLayout();
        PanPersonalDetails.SuspendLayout();
        GrpPoliceReport.SuspendLayout();
        PanPoliceReport.SuspendLayout();
        SuspendLayout();
        // 
        // PanMain
        // 
        PanMain.AutoScroll = true;
        PanMain.AutoSize = true;
        PanMain.Controls.Add(GrpPoliceReport);
        PanMain.Controls.Add(GrpDisappearanceDetails);
        PanMain.Controls.Add(GrpPhysicalDescription);
        PanMain.Controls.Add(GrpPersonalDetails);
        PanMain.Dock = DockStyle.Fill;
        PanMain.Location = new Point(0, 0);
        PanMain.Name = "PanMain";
        PanMain.Size = new Size(1060, 501);
        PanMain.TabIndex = 0;
        // 
        // GrpDisappearanceDetails
        // 
        GrpDisappearanceDetails.AutoSize = true;
        GrpDisappearanceDetails.Controls.Add(PanDisappearanceDetails);
        GrpDisappearanceDetails.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpDisappearanceDetails.Location = new Point(808, 12);
        GrpDisappearanceDetails.Name = "GrpDisappearanceDetails";
        GrpDisappearanceDetails.Size = new Size(240, 200);
        GrpDisappearanceDetails.TabIndex = 8;
        GrpDisappearanceDetails.TabStop = false;
        GrpDisappearanceDetails.Text = "Disappearance Details";
        // 
        // PanDisappearanceDetails
        // 
        PanDisappearanceDetails.Controls.Add(LblDateWentMissing);
        PanDisappearanceDetails.Controls.Add(TxtLocationLastSeen);
        PanDisappearanceDetails.Controls.Add(DtpDateWentMissing);
        PanDisappearanceDetails.Controls.Add(LblLastSeenWearing);
        PanDisappearanceDetails.Controls.Add(LblRequired12);
        PanDisappearanceDetails.Controls.Add(TxtLastSeenWearing);
        PanDisappearanceDetails.Controls.Add(LblLocationLastSeen);
        PanDisappearanceDetails.Dock = DockStyle.Fill;
        PanDisappearanceDetails.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanDisappearanceDetails.Location = new Point(3, 25);
        PanDisappearanceDetails.Name = "PanDisappearanceDetails";
        PanDisappearanceDetails.Size = new Size(234, 172);
        PanDisappearanceDetails.TabIndex = 7;
        // 
        // LblDateWentMissing
        // 
        LblDateWentMissing.AutoSize = true;
        LblDateWentMissing.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblDateWentMissing.Location = new Point(5, 114);
        LblDateWentMissing.Margin = new Padding(0);
        LblDateWentMissing.Name = "LblDateWentMissing";
        LblDateWentMissing.Size = new Size(121, 20);
        LblDateWentMissing.TabIndex = 4;
        LblDateWentMissing.Text = "Date Went Missing";
        LblDateWentMissing.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TxtLocationLastSeen
        // 
        TxtLocationLastSeen.Location = new Point(9, 81);
        TxtLocationLastSeen.Name = "TxtLocationLastSeen";
        TxtLocationLastSeen.Size = new Size(176, 25);
        TxtLocationLastSeen.TabIndex = 3;
        // 
        // DtpDateWentMissing
        // 
        DtpDateWentMissing.CustomFormat = "dd/MM/yyyy HH:mm";
        DtpDateWentMissing.Format = DateTimePickerFormat.Custom;
        DtpDateWentMissing.Location = new Point(8, 137);
        DtpDateWentMissing.MaxDate = new DateTime(2025, 5, 7, 0, 0, 0, 0);
        DtpDateWentMissing.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
        DtpDateWentMissing.Name = "DtpDateWentMissing";
        DtpDateWentMissing.Size = new Size(174, 25);
        DtpDateWentMissing.TabIndex = 6;
        DtpDateWentMissing.Value = new DateTime(2025, 5, 7, 0, 0, 0, 0);
        // 
        // LblLastSeenWearing
        // 
        LblLastSeenWearing.AutoSize = true;
        LblLastSeenWearing.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblLastSeenWearing.Location = new Point(5, 4);
        LblLastSeenWearing.Margin = new Padding(0);
        LblLastSeenWearing.Name = "LblLastSeenWearing";
        LblLastSeenWearing.Size = new Size(121, 20);
        LblLastSeenWearing.TabIndex = 0;
        LblLastSeenWearing.Text = "Last Seen Wearing";
        LblLastSeenWearing.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblRequired12
        // 
        LblRequired12.AutoSize = true;
        LblRequired12.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired12.ForeColor = Color.Red;
        LblRequired12.Location = new Point(125, 117);
        LblRequired12.Margin = new Padding(0);
        LblRequired12.Name = "LblRequired12";
        LblRequired12.Size = new Size(14, 18);
        LblRequired12.TabIndex = 5;
        LblRequired12.Text = "*";
        // 
        // TxtLastSeenWearing
        // 
        TxtLastSeenWearing.Location = new Point(7, 26);
        TxtLastSeenWearing.Name = "TxtLastSeenWearing";
        TxtLastSeenWearing.Size = new Size(176, 25);
        TxtLastSeenWearing.TabIndex = 1;
        // 
        // LblLocationLastSeen
        // 
        LblLocationLastSeen.AutoSize = true;
        LblLocationLastSeen.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblLocationLastSeen.Location = new Point(5, 60);
        LblLocationLastSeen.Margin = new Padding(0);
        LblLocationLastSeen.Name = "LblLocationLastSeen";
        LblLocationLastSeen.Size = new Size(125, 20);
        LblLocationLastSeen.TabIndex = 2;
        LblLocationLastSeen.Text = "Location Last Seen";
        LblLocationLastSeen.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GrpPhysicalDescription
        // 
        GrpPhysicalDescription.AutoSize = true;
        GrpPhysicalDescription.Controls.Add(PanPhysicalDescription);
        GrpPhysicalDescription.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpPhysicalDescription.Location = new Point(410, 12);
        GrpPhysicalDescription.Name = "GrpPhysicalDescription";
        GrpPhysicalDescription.Size = new Size(392, 200);
        GrpPhysicalDescription.TabIndex = 7;
        GrpPhysicalDescription.TabStop = false;
        GrpPhysicalDescription.Text = "Physical Description";
        // 
        // PanPhysicalDescription
        // 
        PanPhysicalDescription.Controls.Add(NupWeight);
        PanPhysicalDescription.Controls.Add(NupHeight);
        PanPhysicalDescription.Controls.Add(TxtMarksTattoos);
        PanPhysicalDescription.Controls.Add(TxtEyeColour);
        PanPhysicalDescription.Controls.Add(LblMarksTattoos);
        PanPhysicalDescription.Controls.Add(LblRequired11);
        PanPhysicalDescription.Controls.Add(LblWeight);
        PanPhysicalDescription.Controls.Add(LblEyeColour);
        PanPhysicalDescription.Controls.Add(LblRequired9);
        PanPhysicalDescription.Controls.Add(LblRequired10);
        PanPhysicalDescription.Controls.Add(LblHeight);
        PanPhysicalDescription.Controls.Add(LblHairColour);
        PanPhysicalDescription.Controls.Add(TxtHairLengthOrStyle);
        PanPhysicalDescription.Controls.Add(LblRequired7);
        PanPhysicalDescription.Controls.Add(LblRequired8);
        PanPhysicalDescription.Controls.Add(TxtHairColour);
        PanPhysicalDescription.Controls.Add(LblHairLengthOrStyle);
        PanPhysicalDescription.Dock = DockStyle.Fill;
        PanPhysicalDescription.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanPhysicalDescription.Location = new Point(3, 25);
        PanPhysicalDescription.Name = "PanPhysicalDescription";
        PanPhysicalDescription.Size = new Size(386, 172);
        PanPhysicalDescription.TabIndex = 7;
        // 
        // NupWeight
        // 
        NupWeight.DecimalPlaces = 2;
        NupWeight.Location = new Point(7, 139);
        NupWeight.Maximum = new decimal(new int[] { 700, 0, 0, 0 });
        NupWeight.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
        NupWeight.Name = "NupWeight";
        NupWeight.Size = new Size(176, 25);
        NupWeight.TabIndex = 15;
        NupWeight.Value = new decimal(new int[] { 1, 0, 0, 65536 });
        // 
        // NupHeight
        // 
        NupHeight.Location = new Point(200, 82);
        NupHeight.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
        NupHeight.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        NupHeight.Name = "NupHeight";
        NupHeight.Size = new Size(176, 25);
        NupHeight.TabIndex = 11;
        NupHeight.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // TxtMarksTattoos
        // 
        TxtMarksTattoos.Location = new Point(200, 139);
        TxtMarksTattoos.Name = "TxtMarksTattoos";
        TxtMarksTattoos.Size = new Size(176, 25);
        TxtMarksTattoos.TabIndex = 17;
        // 
        // TxtEyeColour
        // 
        TxtEyeColour.Location = new Point(7, 82);
        TxtEyeColour.Name = "TxtEyeColour";
        TxtEyeColour.Size = new Size(176, 25);
        TxtEyeColour.TabIndex = 8;
        // 
        // LblMarksTattoos
        // 
        LblMarksTattoos.AutoSize = true;
        LblMarksTattoos.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblMarksTattoos.Location = new Point(198, 116);
        LblMarksTattoos.Margin = new Padding(0);
        LblMarksTattoos.Name = "LblMarksTattoos";
        LblMarksTattoos.Size = new Size(169, 20);
        LblMarksTattoos.TabIndex = 16;
        LblMarksTattoos.Text = "Distinctive Marks / Tattoos";
        LblMarksTattoos.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblRequired11
        // 
        LblRequired11.AutoSize = true;
        LblRequired11.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired11.ForeColor = Color.Red;
        LblRequired11.Location = new Point(80, 117);
        LblRequired11.Margin = new Padding(0);
        LblRequired11.Name = "LblRequired11";
        LblRequired11.Size = new Size(14, 18);
        LblRequired11.TabIndex = 14;
        LblRequired11.Text = "*";
        // 
        // LblWeight
        // 
        LblWeight.AutoSize = true;
        LblWeight.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblWeight.Location = new Point(4, 116);
        LblWeight.Margin = new Padding(0);
        LblWeight.Name = "LblWeight";
        LblWeight.Size = new Size(77, 20);
        LblWeight.TabIndex = 13;
        LblWeight.Text = "Weight (kg)";
        LblWeight.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblEyeColour
        // 
        LblEyeColour.AutoSize = true;
        LblEyeColour.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblEyeColour.Location = new Point(3, 60);
        LblEyeColour.Margin = new Padding(0);
        LblEyeColour.Name = "LblEyeColour";
        LblEyeColour.Size = new Size(76, 20);
        LblEyeColour.TabIndex = 6;
        LblEyeColour.Text = "Eye Colour";
        LblEyeColour.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblRequired9
        // 
        LblRequired9.AutoSize = true;
        LblRequired9.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired9.ForeColor = Color.Red;
        LblRequired9.Location = new Point(78, 61);
        LblRequired9.Margin = new Padding(0);
        LblRequired9.Name = "LblRequired9";
        LblRequired9.Size = new Size(14, 18);
        LblRequired9.TabIndex = 7;
        LblRequired9.Text = "*";
        // 
        // LblRequired10
        // 
        LblRequired10.AutoSize = true;
        LblRequired10.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired10.ForeColor = Color.Red;
        LblRequired10.Location = new Point(274, 62);
        LblRequired10.Margin = new Padding(0);
        LblRequired10.Name = "LblRequired10";
        LblRequired10.Size = new Size(14, 18);
        LblRequired10.TabIndex = 10;
        LblRequired10.Text = "*";
        // 
        // LblHeight
        // 
        LblHeight.AutoSize = true;
        LblHeight.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblHeight.Location = new Point(198, 61);
        LblHeight.Margin = new Padding(0);
        LblHeight.Name = "LblHeight";
        LblHeight.Size = new Size(78, 20);
        LblHeight.TabIndex = 9;
        LblHeight.Text = "Height (cm)";
        LblHeight.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblHairColour
        // 
        LblHairColour.AutoSize = true;
        LblHairColour.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblHairColour.Location = new Point(3, 4);
        LblHairColour.Margin = new Padding(0);
        LblHairColour.Name = "LblHairColour";
        LblHairColour.Size = new Size(79, 20);
        LblHairColour.TabIndex = 0;
        LblHairColour.Text = "Hair Colour";
        LblHairColour.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TxtHairLengthOrStyle
        // 
        TxtHairLengthOrStyle.Location = new Point(200, 26);
        TxtHairLengthOrStyle.Name = "TxtHairLengthOrStyle";
        TxtHairLengthOrStyle.Size = new Size(176, 25);
        TxtHairLengthOrStyle.TabIndex = 5;
        // 
        // LblRequired7
        // 
        LblRequired7.AutoSize = true;
        LblRequired7.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired7.ForeColor = Color.Red;
        LblRequired7.Location = new Point(80, 5);
        LblRequired7.Margin = new Padding(0);
        LblRequired7.Name = "LblRequired7";
        LblRequired7.Size = new Size(14, 18);
        LblRequired7.TabIndex = 1;
        LblRequired7.Text = "*";
        // 
        // LblRequired8
        // 
        LblRequired8.AutoSize = true;
        LblRequired8.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired8.ForeColor = Color.Red;
        LblRequired8.Location = new Point(324, 6);
        LblRequired8.Margin = new Padding(0);
        LblRequired8.Name = "LblRequired8";
        LblRequired8.Size = new Size(14, 18);
        LblRequired8.TabIndex = 4;
        LblRequired8.Text = "*";
        // 
        // TxtHairColour
        // 
        TxtHairColour.Location = new Point(7, 26);
        TxtHairColour.Name = "TxtHairColour";
        TxtHairColour.Size = new Size(176, 25);
        TxtHairColour.TabIndex = 2;
        // 
        // LblHairLengthOrStyle
        // 
        LblHairLengthOrStyle.AutoSize = true;
        LblHairLengthOrStyle.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblHairLengthOrStyle.Location = new Point(196, 5);
        LblHairLengthOrStyle.Margin = new Padding(0);
        LblHairLengthOrStyle.Name = "LblHairLengthOrStyle";
        LblHairLengthOrStyle.Size = new Size(131, 20);
        LblHairLengthOrStyle.TabIndex = 3;
        LblHairLengthOrStyle.Text = "Hair Length Or Style";
        LblHairLengthOrStyle.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GrpPersonalDetails
        // 
        GrpPersonalDetails.AutoSize = true;
        GrpPersonalDetails.Controls.Add(PanPersonalDetails);
        GrpPersonalDetails.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpPersonalDetails.Location = new Point(12, 12);
        GrpPersonalDetails.Name = "GrpPersonalDetails";
        GrpPersonalDetails.Size = new Size(392, 200);
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
        PanPersonalDetails.Size = new Size(386, 172);
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
        // GrpPoliceReport
        // 
        GrpPoliceReport.AutoSize = true;
        GrpPoliceReport.Controls.Add(PanPoliceReport);
        GrpPoliceReport.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpPoliceReport.Location = new Point(12, 240);
        GrpPoliceReport.Name = "GrpPoliceReport";
        GrpPoliceReport.Size = new Size(392, 149);
        GrpPoliceReport.TabIndex = 9;
        GrpPoliceReport.TabStop = false;
        GrpPoliceReport.Text = "Police Report";
        // 
        // PanPoliceReport
        // 
        PanPoliceReport.Controls.Add(TxtInvestigatingOfficerContactNumber);
        PanPoliceReport.Controls.Add(TxtInvestigatingOfficer);
        PanPoliceReport.Controls.Add(LblInvestigatingOfficer);
        PanPoliceReport.Controls.Add(LblRequired15);
        PanPoliceReport.Controls.Add(LblRequired16);
        PanPoliceReport.Controls.Add(LblInvestigatingOfficerContactNumber);
        PanPoliceReport.Controls.Add(LblPoliceStation);
        PanPoliceReport.Controls.Add(TxtCaseNumber);
        PanPoliceReport.Controls.Add(LblRequired13);
        PanPoliceReport.Controls.Add(LblRequired14);
        PanPoliceReport.Controls.Add(TxtPoliceStation);
        PanPoliceReport.Controls.Add(LblCaseNumber);
        PanPoliceReport.Dock = DockStyle.Fill;
        PanPoliceReport.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanPoliceReport.Location = new Point(3, 25);
        PanPoliceReport.Name = "PanPoliceReport";
        PanPoliceReport.Size = new Size(386, 121);
        PanPoliceReport.TabIndex = 7;
        // 
        // LblInvestigatingOfficer
        // 
        LblInvestigatingOfficer.AutoSize = true;
        LblInvestigatingOfficer.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblInvestigatingOfficer.Location = new Point(3, 60);
        LblInvestigatingOfficer.Margin = new Padding(0);
        LblInvestigatingOfficer.Name = "LblInvestigatingOfficer";
        LblInvestigatingOfficer.Size = new Size(133, 20);
        LblInvestigatingOfficer.TabIndex = 6;
        LblInvestigatingOfficer.Text = "Investigating Officer";
        LblInvestigatingOfficer.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblRequired15
        // 
        LblRequired15.AutoSize = true;
        LblRequired15.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired15.ForeColor = Color.Red;
        LblRequired15.Location = new Point(136, 62);
        LblRequired15.Margin = new Padding(0);
        LblRequired15.Name = "LblRequired15";
        LblRequired15.Size = new Size(14, 18);
        LblRequired15.TabIndex = 7;
        LblRequired15.Text = "*";
        // 
        // LblRequired16
        // 
        LblRequired16.AutoSize = true;
        LblRequired16.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired16.ForeColor = Color.Red;
        LblRequired16.Location = new Point(348, 62);
        LblRequired16.Margin = new Padding(0);
        LblRequired16.Name = "LblRequired16";
        LblRequired16.Size = new Size(14, 18);
        LblRequired16.TabIndex = 10;
        LblRequired16.Text = "*";
        // 
        // LblInvestigatingOfficerContactNumber
        // 
        LblInvestigatingOfficerContactNumber.AutoSize = true;
        LblInvestigatingOfficerContactNumber.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblInvestigatingOfficerContactNumber.Location = new Point(198, 61);
        LblInvestigatingOfficerContactNumber.Margin = new Padding(0);
        LblInvestigatingOfficerContactNumber.Name = "LblInvestigatingOfficerContactNumber";
        LblInvestigatingOfficerContactNumber.Size = new Size(151, 20);
        LblInvestigatingOfficerContactNumber.TabIndex = 9;
        LblInvestigatingOfficerContactNumber.Text = "Officer Contact Number";
        LblInvestigatingOfficerContactNumber.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // LblPoliceStation
        // 
        LblPoliceStation.AutoSize = true;
        LblPoliceStation.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblPoliceStation.Location = new Point(3, 4);
        LblPoliceStation.Margin = new Padding(0);
        LblPoliceStation.Name = "LblPoliceStation";
        LblPoliceStation.Size = new Size(93, 20);
        LblPoliceStation.TabIndex = 0;
        LblPoliceStation.Text = "Police Station";
        LblPoliceStation.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TxtCaseNumber
        // 
        TxtCaseNumber.Location = new Point(200, 26);
        TxtCaseNumber.Name = "TxtCaseNumber";
        TxtCaseNumber.Size = new Size(176, 25);
        TxtCaseNumber.TabIndex = 5;
        // 
        // LblRequired13
        // 
        LblRequired13.AutoSize = true;
        LblRequired13.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired13.ForeColor = Color.Red;
        LblRequired13.Location = new Point(96, 6);
        LblRequired13.Margin = new Padding(0);
        LblRequired13.Name = "LblRequired13";
        LblRequired13.Size = new Size(14, 18);
        LblRequired13.TabIndex = 1;
        LblRequired13.Text = "*";
        // 
        // LblRequired14
        // 
        LblRequired14.AutoSize = true;
        LblRequired14.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblRequired14.ForeColor = Color.Red;
        LblRequired14.Location = new Point(285, 6);
        LblRequired14.Margin = new Padding(0);
        LblRequired14.Name = "LblRequired14";
        LblRequired14.Size = new Size(14, 18);
        LblRequired14.TabIndex = 4;
        LblRequired14.Text = "*";
        // 
        // TxtPoliceStation
        // 
        TxtPoliceStation.Location = new Point(7, 26);
        TxtPoliceStation.Name = "TxtPoliceStation";
        TxtPoliceStation.Size = new Size(176, 25);
        TxtPoliceStation.TabIndex = 2;
        // 
        // LblCaseNumber
        // 
        LblCaseNumber.AutoSize = true;
        LblCaseNumber.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblCaseNumber.Location = new Point(196, 5);
        LblCaseNumber.Margin = new Padding(0);
        LblCaseNumber.Name = "LblCaseNumber";
        LblCaseNumber.Size = new Size(90, 20);
        LblCaseNumber.TabIndex = 3;
        LblCaseNumber.Text = "Case Number";
        LblCaseNumber.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TxtInvestigatingOfficer
        // 
        TxtInvestigatingOfficer.Location = new Point(7, 84);
        TxtInvestigatingOfficer.Name = "TxtInvestigatingOfficer";
        TxtInvestigatingOfficer.Size = new Size(176, 25);
        TxtInvestigatingOfficer.TabIndex = 11;
        // 
        // TxtInvestigatingOfficerContactNumber
        // 
        TxtInvestigatingOfficerContactNumber.Location = new Point(200, 84);
        TxtInvestigatingOfficerContactNumber.Name = "TxtInvestigatingOfficerContactNumber";
        TxtInvestigatingOfficerContactNumber.Size = new Size(176, 25);
        TxtInvestigatingOfficerContactNumber.TabIndex = 12;
        // 
        // ReportMissingPersonForm
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1060, 501);
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
        GrpDisappearanceDetails.ResumeLayout(false);
        PanDisappearanceDetails.ResumeLayout(false);
        PanDisappearanceDetails.PerformLayout();
        GrpPhysicalDescription.ResumeLayout(false);
        PanPhysicalDescription.ResumeLayout(false);
        PanPhysicalDescription.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)NupWeight).EndInit();
        ((System.ComponentModel.ISupportInitialize)NupHeight).EndInit();
        GrpPersonalDetails.ResumeLayout(false);
        PanPersonalDetails.ResumeLayout(false);
        PanPersonalDetails.PerformLayout();
        GrpPoliceReport.ResumeLayout(false);
        PanPoliceReport.ResumeLayout(false);
        PanPoliceReport.PerformLayout();
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
    private GroupBox GrpPhysicalDescription;
    private Panel PanPhysicalDescription;
    private Label LblMarksTattoos;
    private Label LblRequired11;
    private Label LblWeight;
    private Label LblEyeColour;
    private Label LblRequired9;
    private Label LblRequired10;
    private Label LblHeight;
    private Label LblHairColour;
    private TextBox TxtHairLengthOrStyle;
    private Label LblRequired7;
    private Label LblRequired8;
    private TextBox TxtHairColour;
    private Label LblHairLengthOrStyle;
    private TextBox TxtMarksTattoos;
    private TextBox TxtEyeColour;
    private NumericUpDown NupHeight;
    private NumericUpDown NupWeight;
    private GroupBox GrpDisappearanceDetails;
    private Panel PanDisappearanceDetails;
    private DateTimePicker DtpDateWentMissing;
    private Label LblDateWentMissing;
    private Label LblLastSeenWearing;
    private Label LblRequired12;
    private TextBox TxtLastSeenWearing;
    private Label LblLocationLastSeen;
    private TextBox TxtLocationLastSeen;
    private GroupBox GrpPoliceReport;
    private Panel PanPoliceReport;
    private Label LblInvestigatingOfficer;
    private Label LblRequired15;
    private Label LblRequired16;
    private Label LblInvestigatingOfficerContactNumber;
    private Label LblPoliceStation;
    private TextBox TxtCaseNumber;
    private Label LblRequired13;
    private Label LblRequired14;
    private TextBox TxtPoliceStation;
    private Label LblCaseNumber;
    private TextBox TxtInvestigatingOfficer;
    private TextBox TxtInvestigatingOfficerContactNumber;
}