namespace MissingChildrenSA.Forms.Moderation;

partial class ModerateMissingPersonForm
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
        GrpModeration = new GroupBox();
        PanModeration = new Panel();
        TabPanActions = new TableLayoutPanel();
        BtnApprove = new Button();
        BtnFailModeration = new Button();
        BtnStartModeration = new Button();
        GrpPhoto = new GroupBox();
        PanPhoto = new Panel();
        TabPanPhoto = new TableLayoutPanel();
        PicPreview = new PictureBox();
        GrpFamilyContact = new GroupBox();
        PanFamilyContact = new Panel();
        LblFamilyContactName = new Label();
        TxtFamilyContactNumber = new TextBox();
        TxtFamilyContactName = new TextBox();
        LblContactNumber = new Label();
        GrpPoliceReport = new GroupBox();
        PanPoliceReport = new Panel();
        TxtInvestigatingOfficerContactNumber = new TextBox();
        TxtInvestigatingOfficer = new TextBox();
        LblInvestigatingOfficer = new Label();
        LblInvestigatingOfficerContactNumber = new Label();
        LblPoliceStation = new Label();
        TxtCaseNumber = new TextBox();
        TxtPoliceStation = new TextBox();
        LblCaseNumber = new Label();
        GrpDisappearanceDetails = new GroupBox();
        PanDisappearanceDetails = new Panel();
        TxtDateWentMissing = new TextBox();
        LblDateWentMissing = new Label();
        TxtLocationLastSeen = new TextBox();
        LblLastSeenWearing = new Label();
        TxtLastSeenWearing = new TextBox();
        LblLocationLastSeen = new Label();
        GrpPhysicalDescription = new GroupBox();
        PanPhysicalDescription = new Panel();
        TxtWeight = new TextBox();
        TxtHeight = new TextBox();
        TxtMarksTattoos = new TextBox();
        TxtEyeColour = new TextBox();
        LblMarksTattoos = new Label();
        LblWeight = new Label();
        LblEyeColour = new Label();
        LblHeight = new Label();
        LblHairColour = new Label();
        TxtHairLengthOrStyle = new TextBox();
        TxtHairColour = new TextBox();
        LblHairLengthOrStyle = new Label();
        GrpPersonalDetails = new GroupBox();
        PanPersonalDetails = new Panel();
        TxtProvince = new TextBox();
        TxtRace = new TextBox();
        TxtGender = new TextBox();
        TxtDateOfBirth = new TextBox();
        LblProvince = new Label();
        LblRace = new Label();
        LblDateOfBirth = new Label();
        LblGender = new Label();
        LblName = new Label();
        TxtSurname = new TextBox();
        TxtName = new TextBox();
        LblSurname = new Label();
        MainTooltip = new ToolTip(components);
        PanMain.SuspendLayout();
        GrpModeration.SuspendLayout();
        PanModeration.SuspendLayout();
        TabPanActions.SuspendLayout();
        GrpPhoto.SuspendLayout();
        PanPhoto.SuspendLayout();
        TabPanPhoto.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)PicPreview).BeginInit();
        GrpFamilyContact.SuspendLayout();
        PanFamilyContact.SuspendLayout();
        GrpPoliceReport.SuspendLayout();
        PanPoliceReport.SuspendLayout();
        GrpDisappearanceDetails.SuspendLayout();
        PanDisappearanceDetails.SuspendLayout();
        GrpPhysicalDescription.SuspendLayout();
        PanPhysicalDescription.SuspendLayout();
        GrpPersonalDetails.SuspendLayout();
        PanPersonalDetails.SuspendLayout();
        SuspendLayout();
        // 
        // PanMain
        // 
        PanMain.AutoScroll = true;
        PanMain.AutoSize = true;
        PanMain.Controls.Add(GrpModeration);
        PanMain.Controls.Add(BtnStartModeration);
        PanMain.Controls.Add(GrpPhoto);
        PanMain.Controls.Add(GrpFamilyContact);
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
        // GrpModeration
        // 
        GrpModeration.AutoSize = true;
        GrpModeration.Controls.Add(PanModeration);
        GrpModeration.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpModeration.Location = new Point(15, 403);
        GrpModeration.Name = "GrpModeration";
        GrpModeration.Size = new Size(338, 86);
        GrpModeration.TabIndex = 13;
        GrpModeration.TabStop = false;
        GrpModeration.Text = "Moderation";
        // 
        // PanModeration
        // 
        PanModeration.Controls.Add(TabPanActions);
        PanModeration.Dock = DockStyle.Fill;
        PanModeration.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanModeration.Location = new Point(3, 25);
        PanModeration.Name = "PanModeration";
        PanModeration.Size = new Size(332, 58);
        PanModeration.TabIndex = 7;
        // 
        // TabPanActions
        // 
        TabPanActions.ColumnCount = 2;
        TabPanActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanActions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        TabPanActions.Controls.Add(BtnApprove, 1, 0);
        TabPanActions.Controls.Add(BtnFailModeration, 0, 0);
        TabPanActions.Dock = DockStyle.Fill;
        TabPanActions.Location = new Point(0, 0);
        TabPanActions.Name = "TabPanActions";
        TabPanActions.RowCount = 1;
        TabPanActions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        TabPanActions.Size = new Size(332, 58);
        TabPanActions.TabIndex = 0;
        // 
        // BtnApprove
        // 
        BtnApprove.Anchor = AnchorStyles.None;
        BtnApprove.AutoSize = true;
        BtnApprove.BackColor = Color.Green;
        BtnApprove.Cursor = Cursors.Hand;
        BtnApprove.FlatAppearance.BorderSize = 0;
        BtnApprove.FlatStyle = FlatStyle.Popup;
        BtnApprove.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnApprove.ForeColor = Color.White;
        BtnApprove.Location = new Point(176, 13);
        BtnApprove.Margin = new Padding(5, 3, 5, 3);
        BtnApprove.Name = "BtnApprove";
        BtnApprove.Size = new Size(145, 31);
        BtnApprove.TabIndex = 14;
        BtnApprove.Text = "Approve";
        BtnApprove.UseVisualStyleBackColor = false;
        BtnApprove.Click += BtnApprove_Click;
        // 
        // BtnFailModeration
        // 
        BtnFailModeration.Anchor = AnchorStyles.None;
        BtnFailModeration.AutoSize = true;
        BtnFailModeration.BackColor = Color.FromArgb(237, 31, 39);
        BtnFailModeration.Cursor = Cursors.Hand;
        BtnFailModeration.FlatAppearance.BorderSize = 0;
        BtnFailModeration.FlatStyle = FlatStyle.Popup;
        BtnFailModeration.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnFailModeration.ForeColor = Color.White;
        BtnFailModeration.Location = new Point(10, 13);
        BtnFailModeration.Margin = new Padding(5, 3, 5, 3);
        BtnFailModeration.Name = "BtnFailModeration";
        BtnFailModeration.Size = new Size(145, 31);
        BtnFailModeration.TabIndex = 13;
        BtnFailModeration.Text = "Fail Moderation";
        BtnFailModeration.UseVisualStyleBackColor = false;
        BtnFailModeration.Click += BtnFailModeration_Click;
        // 
        // BtnStartModeration
        // 
        BtnStartModeration.Anchor = AnchorStyles.None;
        BtnStartModeration.AutoSize = true;
        BtnStartModeration.BackColor = Color.FromArgb(237, 31, 39);
        BtnStartModeration.Cursor = Cursors.Hand;
        BtnStartModeration.FlatAppearance.BorderSize = 0;
        BtnStartModeration.FlatStyle = FlatStyle.Popup;
        BtnStartModeration.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BtnStartModeration.ForeColor = Color.White;
        BtnStartModeration.Location = new Point(361, 434);
        BtnStartModeration.Margin = new Padding(5, 3, 5, 3);
        BtnStartModeration.Name = "BtnStartModeration";
        BtnStartModeration.Size = new Size(145, 31);
        BtnStartModeration.TabIndex = 12;
        BtnStartModeration.Text = "Start Moderation";
        BtnStartModeration.UseVisualStyleBackColor = false;
        BtnStartModeration.Click += BtnStartModeration_Click;
        // 
        // GrpPhoto
        // 
        GrpPhoto.AutoSize = true;
        GrpPhoto.Controls.Add(PanPhoto);
        GrpPhoto.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpPhoto.Location = new Point(808, 240);
        GrpPhoto.Name = "GrpPhoto";
        GrpPhoto.Size = new Size(240, 249);
        GrpPhoto.TabIndex = 11;
        GrpPhoto.TabStop = false;
        GrpPhoto.Text = "Missing Person Photo";
        // 
        // PanPhoto
        // 
        PanPhoto.Controls.Add(TabPanPhoto);
        PanPhoto.Dock = DockStyle.Fill;
        PanPhoto.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanPhoto.Location = new Point(3, 25);
        PanPhoto.Name = "PanPhoto";
        PanPhoto.Size = new Size(234, 221);
        PanPhoto.TabIndex = 7;
        // 
        // TabPanPhoto
        // 
        TabPanPhoto.ColumnCount = 1;
        TabPanPhoto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TabPanPhoto.Controls.Add(PicPreview, 0, 0);
        TabPanPhoto.Dock = DockStyle.Fill;
        TabPanPhoto.Location = new Point(0, 0);
        TabPanPhoto.Name = "TabPanPhoto";
        TabPanPhoto.RowCount = 1;
        TabPanPhoto.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        TabPanPhoto.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        TabPanPhoto.Size = new Size(234, 221);
        TabPanPhoto.TabIndex = 0;
        // 
        // PicPreview
        // 
        PicPreview.Dock = DockStyle.Fill;
        PicPreview.Location = new Point(3, 3);
        PicPreview.Name = "PicPreview";
        PicPreview.Size = new Size(228, 215);
        PicPreview.SizeMode = PictureBoxSizeMode.Zoom;
        PicPreview.TabIndex = 0;
        PicPreview.TabStop = false;
        // 
        // GrpFamilyContact
        // 
        GrpFamilyContact.AutoSize = true;
        GrpFamilyContact.Controls.Add(PanFamilyContact);
        GrpFamilyContact.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GrpFamilyContact.Location = new Point(410, 240);
        GrpFamilyContact.Name = "GrpFamilyContact";
        GrpFamilyContact.Size = new Size(392, 149);
        GrpFamilyContact.TabIndex = 10;
        GrpFamilyContact.TabStop = false;
        GrpFamilyContact.Text = "Family Contact";
        // 
        // PanFamilyContact
        // 
        PanFamilyContact.Controls.Add(LblFamilyContactName);
        PanFamilyContact.Controls.Add(TxtFamilyContactNumber);
        PanFamilyContact.Controls.Add(TxtFamilyContactName);
        PanFamilyContact.Controls.Add(LblContactNumber);
        PanFamilyContact.Dock = DockStyle.Fill;
        PanFamilyContact.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanFamilyContact.Location = new Point(3, 25);
        PanFamilyContact.Name = "PanFamilyContact";
        PanFamilyContact.Size = new Size(386, 121);
        PanFamilyContact.TabIndex = 7;
        // 
        // LblFamilyContactName
        // 
        LblFamilyContactName.AutoSize = true;
        LblFamilyContactName.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblFamilyContactName.Location = new Point(3, 4);
        LblFamilyContactName.Margin = new Padding(0);
        LblFamilyContactName.Name = "LblFamilyContactName";
        LblFamilyContactName.Size = new Size(93, 20);
        LblFamilyContactName.TabIndex = 0;
        LblFamilyContactName.Text = "Contact Name";
        LblFamilyContactName.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // TxtFamilyContactNumber
        // 
        TxtFamilyContactNumber.BackColor = Color.White;
        TxtFamilyContactNumber.Location = new Point(200, 26);
        TxtFamilyContactNumber.Name = "TxtFamilyContactNumber";
        TxtFamilyContactNumber.ReadOnly = true;
        TxtFamilyContactNumber.Size = new Size(176, 25);
        TxtFamilyContactNumber.TabIndex = 3;
        // 
        // TxtFamilyContactName
        // 
        TxtFamilyContactName.BackColor = Color.White;
        TxtFamilyContactName.Location = new Point(7, 26);
        TxtFamilyContactName.Name = "TxtFamilyContactName";
        TxtFamilyContactName.ReadOnly = true;
        TxtFamilyContactName.Size = new Size(176, 25);
        TxtFamilyContactName.TabIndex = 1;
        // 
        // LblContactNumber
        // 
        LblContactNumber.AutoSize = true;
        LblContactNumber.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        LblContactNumber.Location = new Point(196, 5);
        LblContactNumber.Margin = new Padding(0);
        LblContactNumber.Name = "LblContactNumber";
        LblContactNumber.Size = new Size(107, 20);
        LblContactNumber.TabIndex = 2;
        LblContactNumber.Text = "Contact Number";
        LblContactNumber.TextAlign = ContentAlignment.MiddleLeft;
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
        PanPoliceReport.Controls.Add(LblInvestigatingOfficerContactNumber);
        PanPoliceReport.Controls.Add(LblPoliceStation);
        PanPoliceReport.Controls.Add(TxtCaseNumber);
        PanPoliceReport.Controls.Add(TxtPoliceStation);
        PanPoliceReport.Controls.Add(LblCaseNumber);
        PanPoliceReport.Dock = DockStyle.Fill;
        PanPoliceReport.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanPoliceReport.Location = new Point(3, 25);
        PanPoliceReport.Name = "PanPoliceReport";
        PanPoliceReport.Size = new Size(386, 121);
        PanPoliceReport.TabIndex = 7;
        // 
        // TxtInvestigatingOfficerContactNumber
        // 
        TxtInvestigatingOfficerContactNumber.BackColor = Color.White;
        TxtInvestigatingOfficerContactNumber.Location = new Point(200, 84);
        TxtInvestigatingOfficerContactNumber.Name = "TxtInvestigatingOfficerContactNumber";
        TxtInvestigatingOfficerContactNumber.ReadOnly = true;
        TxtInvestigatingOfficerContactNumber.Size = new Size(176, 25);
        TxtInvestigatingOfficerContactNumber.TabIndex = 12;
        // 
        // TxtInvestigatingOfficer
        // 
        TxtInvestigatingOfficer.BackColor = Color.White;
        TxtInvestigatingOfficer.Location = new Point(7, 84);
        TxtInvestigatingOfficer.Name = "TxtInvestigatingOfficer";
        TxtInvestigatingOfficer.ReadOnly = true;
        TxtInvestigatingOfficer.Size = new Size(176, 25);
        TxtInvestigatingOfficer.TabIndex = 11;
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
        TxtCaseNumber.BackColor = Color.White;
        TxtCaseNumber.Location = new Point(200, 26);
        TxtCaseNumber.Name = "TxtCaseNumber";
        TxtCaseNumber.ReadOnly = true;
        TxtCaseNumber.Size = new Size(176, 25);
        TxtCaseNumber.TabIndex = 5;
        // 
        // TxtPoliceStation
        // 
        TxtPoliceStation.BackColor = Color.White;
        TxtPoliceStation.Location = new Point(7, 26);
        TxtPoliceStation.Name = "TxtPoliceStation";
        TxtPoliceStation.ReadOnly = true;
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
        PanDisappearanceDetails.Controls.Add(TxtDateWentMissing);
        PanDisappearanceDetails.Controls.Add(LblDateWentMissing);
        PanDisappearanceDetails.Controls.Add(TxtLocationLastSeen);
        PanDisappearanceDetails.Controls.Add(LblLastSeenWearing);
        PanDisappearanceDetails.Controls.Add(TxtLastSeenWearing);
        PanDisappearanceDetails.Controls.Add(LblLocationLastSeen);
        PanDisappearanceDetails.Dock = DockStyle.Fill;
        PanDisappearanceDetails.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanDisappearanceDetails.Location = new Point(3, 25);
        PanDisappearanceDetails.Name = "PanDisappearanceDetails";
        PanDisappearanceDetails.Size = new Size(234, 172);
        PanDisappearanceDetails.TabIndex = 7;
        // 
        // TxtDateWentMissing
        // 
        TxtDateWentMissing.BackColor = Color.White;
        TxtDateWentMissing.Location = new Point(9, 139);
        TxtDateWentMissing.Name = "TxtDateWentMissing";
        TxtDateWentMissing.ReadOnly = true;
        TxtDateWentMissing.Size = new Size(176, 25);
        TxtDateWentMissing.TabIndex = 20;
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
        TxtLocationLastSeen.BackColor = Color.White;
        TxtLocationLastSeen.Location = new Point(9, 81);
        TxtLocationLastSeen.Name = "TxtLocationLastSeen";
        TxtLocationLastSeen.ReadOnly = true;
        TxtLocationLastSeen.Size = new Size(176, 25);
        TxtLocationLastSeen.TabIndex = 3;
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
        // TxtLastSeenWearing
        // 
        TxtLastSeenWearing.BackColor = Color.White;
        TxtLastSeenWearing.Location = new Point(7, 26);
        TxtLastSeenWearing.Name = "TxtLastSeenWearing";
        TxtLastSeenWearing.ReadOnly = true;
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
        PanPhysicalDescription.Controls.Add(TxtWeight);
        PanPhysicalDescription.Controls.Add(TxtHeight);
        PanPhysicalDescription.Controls.Add(TxtMarksTattoos);
        PanPhysicalDescription.Controls.Add(TxtEyeColour);
        PanPhysicalDescription.Controls.Add(LblMarksTattoos);
        PanPhysicalDescription.Controls.Add(LblWeight);
        PanPhysicalDescription.Controls.Add(LblEyeColour);
        PanPhysicalDescription.Controls.Add(LblHeight);
        PanPhysicalDescription.Controls.Add(LblHairColour);
        PanPhysicalDescription.Controls.Add(TxtHairLengthOrStyle);
        PanPhysicalDescription.Controls.Add(TxtHairColour);
        PanPhysicalDescription.Controls.Add(LblHairLengthOrStyle);
        PanPhysicalDescription.Dock = DockStyle.Fill;
        PanPhysicalDescription.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanPhysicalDescription.Location = new Point(3, 25);
        PanPhysicalDescription.Name = "PanPhysicalDescription";
        PanPhysicalDescription.Size = new Size(386, 172);
        PanPhysicalDescription.TabIndex = 7;
        // 
        // TxtWeight
        // 
        TxtWeight.BackColor = Color.White;
        TxtWeight.Location = new Point(7, 139);
        TxtWeight.Name = "TxtWeight";
        TxtWeight.ReadOnly = true;
        TxtWeight.Size = new Size(176, 25);
        TxtWeight.TabIndex = 19;
        // 
        // TxtHeight
        // 
        TxtHeight.BackColor = Color.White;
        TxtHeight.Location = new Point(200, 82);
        TxtHeight.Name = "TxtHeight";
        TxtHeight.ReadOnly = true;
        TxtHeight.Size = new Size(176, 25);
        TxtHeight.TabIndex = 18;
        // 
        // TxtMarksTattoos
        // 
        TxtMarksTattoos.BackColor = Color.White;
        TxtMarksTattoos.Location = new Point(200, 139);
        TxtMarksTattoos.Name = "TxtMarksTattoos";
        TxtMarksTattoos.ReadOnly = true;
        TxtMarksTattoos.Size = new Size(176, 25);
        TxtMarksTattoos.TabIndex = 17;
        // 
        // TxtEyeColour
        // 
        TxtEyeColour.BackColor = Color.White;
        TxtEyeColour.Location = new Point(7, 82);
        TxtEyeColour.Name = "TxtEyeColour";
        TxtEyeColour.ReadOnly = true;
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
        TxtHairLengthOrStyle.BackColor = Color.White;
        TxtHairLengthOrStyle.Location = new Point(200, 26);
        TxtHairLengthOrStyle.Name = "TxtHairLengthOrStyle";
        TxtHairLengthOrStyle.ReadOnly = true;
        TxtHairLengthOrStyle.Size = new Size(176, 25);
        TxtHairLengthOrStyle.TabIndex = 5;
        // 
        // TxtHairColour
        // 
        TxtHairColour.BackColor = Color.White;
        TxtHairColour.Location = new Point(7, 26);
        TxtHairColour.Name = "TxtHairColour";
        TxtHairColour.ReadOnly = true;
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
        PanPersonalDetails.Controls.Add(TxtProvince);
        PanPersonalDetails.Controls.Add(TxtRace);
        PanPersonalDetails.Controls.Add(TxtGender);
        PanPersonalDetails.Controls.Add(TxtDateOfBirth);
        PanPersonalDetails.Controls.Add(LblProvince);
        PanPersonalDetails.Controls.Add(LblRace);
        PanPersonalDetails.Controls.Add(LblDateOfBirth);
        PanPersonalDetails.Controls.Add(LblGender);
        PanPersonalDetails.Controls.Add(LblName);
        PanPersonalDetails.Controls.Add(TxtSurname);
        PanPersonalDetails.Controls.Add(TxtName);
        PanPersonalDetails.Controls.Add(LblSurname);
        PanPersonalDetails.Dock = DockStyle.Fill;
        PanPersonalDetails.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        PanPersonalDetails.Location = new Point(3, 25);
        PanPersonalDetails.Name = "PanPersonalDetails";
        PanPersonalDetails.Size = new Size(386, 172);
        PanPersonalDetails.TabIndex = 7;
        // 
        // TxtProvince
        // 
        TxtProvince.BackColor = Color.White;
        TxtProvince.Location = new Point(200, 137);
        TxtProvince.Name = "TxtProvince";
        TxtProvince.ReadOnly = true;
        TxtProvince.Size = new Size(176, 25);
        TxtProvince.TabIndex = 22;
        // 
        // TxtRace
        // 
        TxtRace.BackColor = Color.White;
        TxtRace.Location = new Point(7, 138);
        TxtRace.Name = "TxtRace";
        TxtRace.ReadOnly = true;
        TxtRace.Size = new Size(176, 25);
        TxtRace.TabIndex = 21;
        // 
        // TxtGender
        // 
        TxtGender.BackColor = Color.White;
        TxtGender.Location = new Point(200, 82);
        TxtGender.Name = "TxtGender";
        TxtGender.ReadOnly = true;
        TxtGender.Size = new Size(176, 25);
        TxtGender.TabIndex = 20;
        // 
        // TxtDateOfBirth
        // 
        TxtDateOfBirth.BackColor = Color.White;
        TxtDateOfBirth.Location = new Point(7, 82);
        TxtDateOfBirth.Name = "TxtDateOfBirth";
        TxtDateOfBirth.ReadOnly = true;
        TxtDateOfBirth.Size = new Size(176, 25);
        TxtDateOfBirth.TabIndex = 19;
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
        TxtSurname.BackColor = Color.White;
        TxtSurname.Location = new Point(200, 26);
        TxtSurname.Name = "TxtSurname";
        TxtSurname.ReadOnly = true;
        TxtSurname.Size = new Size(176, 25);
        TxtSurname.TabIndex = 5;
        // 
        // TxtName
        // 
        TxtName.BackColor = Color.White;
        TxtName.Location = new Point(7, 26);
        TxtName.Name = "TxtName";
        TxtName.ReadOnly = true;
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
        // ModerateMissingPersonForm
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
        Name = "ModerateMissingPersonForm";
        ShowInTaskbar = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Moderate Missing Person";
        FormClosing += ModerateMissingPersonForm_FormClosing;
        Load += ModerateMissingPersonForm_Load;
        PanMain.ResumeLayout(false);
        PanMain.PerformLayout();
        GrpModeration.ResumeLayout(false);
        PanModeration.ResumeLayout(false);
        TabPanActions.ResumeLayout(false);
        TabPanActions.PerformLayout();
        GrpPhoto.ResumeLayout(false);
        PanPhoto.ResumeLayout(false);
        TabPanPhoto.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)PicPreview).EndInit();
        GrpFamilyContact.ResumeLayout(false);
        PanFamilyContact.ResumeLayout(false);
        PanFamilyContact.PerformLayout();
        GrpPoliceReport.ResumeLayout(false);
        PanPoliceReport.ResumeLayout(false);
        PanPoliceReport.PerformLayout();
        GrpDisappearanceDetails.ResumeLayout(false);
        PanDisappearanceDetails.ResumeLayout(false);
        PanDisappearanceDetails.PerformLayout();
        GrpPhysicalDescription.ResumeLayout(false);
        PanPhysicalDescription.ResumeLayout(false);
        PanPhysicalDescription.PerformLayout();
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
    private TextBox TxtName;
    private TextBox TxtSurname;
    private Label LblSurname;
    private GroupBox GrpPersonalDetails;
    private Panel PanPersonalDetails;
    private Label LblDateOfBirth;
    private Label LblGender;
    private Label LblRace;
    private Label LblProvince;
    private GroupBox GrpPhysicalDescription;
    private Panel PanPhysicalDescription;
    private Label LblMarksTattoos;
    private Label LblWeight;
    private Label LblEyeColour;
    private Label LblHeight;
    private Label LblHairColour;
    private TextBox TxtHairLengthOrStyle;
    private TextBox TxtHairColour;
    private Label LblHairLengthOrStyle;
    private TextBox TxtMarksTattoos;
    private TextBox TxtEyeColour;
    private GroupBox GrpDisappearanceDetails;
    private Panel PanDisappearanceDetails;
    private Label LblDateWentMissing;
    private Label LblLastSeenWearing;
    private TextBox TxtLastSeenWearing;
    private Label LblLocationLastSeen;
    private TextBox TxtLocationLastSeen;
    private GroupBox GrpPoliceReport;
    private Panel PanPoliceReport;
    private Label LblInvestigatingOfficer;
    private Label LblInvestigatingOfficerContactNumber;
    private Label LblPoliceStation;
    private TextBox TxtCaseNumber;
    private TextBox TxtPoliceStation;
    private Label LblCaseNumber;
    private TextBox TxtInvestigatingOfficer;
    private TextBox TxtInvestigatingOfficerContactNumber;
    private GroupBox GrpFamilyContact;
    private Panel PanFamilyContact;
    private Label LblFamilyContactName;
    private TextBox TxtFamilyContactNumber;
    private TextBox TxtFamilyContactName;
    private Label LblContactNumber;
    private GroupBox GrpPhoto;
    private Panel PanPhoto;
    private TableLayoutPanel TabPanPhoto;
    private PictureBox PicPreview;
    private Button BtnStartModeration;
    private GroupBox GrpModeration;
    private Panel PanModeration;
    private TableLayoutPanel TabPanActions;
    private Button BtnApprove;
    private Button BtnFailModeration;
    private TextBox TxtDateOfBirth;
    private TextBox TxtGender;
    private TextBox TxtRace;
    private TextBox TxtProvince;
    private TextBox TxtHeight;
    private TextBox TxtWeight;
    private TextBox TxtDateWentMissing;
}