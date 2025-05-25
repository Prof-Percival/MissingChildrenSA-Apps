namespace MissingChildrenSA.Forms.MissingPersons;

public partial class MissingPersonForm : Form
{
    private readonly IServiceProvider _serviceProvider;

    private Models.MissingPersons.MissingPersonModel _missingPerson;

    public MissingPersonForm(
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _serviceProvider = serviceProvider;
    }

    private async void MissingPersonForm_Load(object sender, EventArgs e)
    {
        //_missingPerson = _serviceProvider.GetRequiredService<ViewUsersForm>()._selectedUser;

        await PopulateFormAsync();
    }

    private async Task PopulateFormAsync()
    {
        //Personal Details
        TxtName.Text = _missingPerson.FirstName;
        TxtSurname.Text = _missingPerson.LastName;
        TxtDateOfBirth.Text = _missingPerson.DateOfBirth;
        TxtGender.Text = _missingPerson.Gender;
        TxtRace.Text = _missingPerson.Race;
        TxtProvince.Text = _missingPerson.Province;

        //Physical Description
        TxtHairColour.Text = _missingPerson.HairColour;
        TxtHairLengthOrStyle.Text = _missingPerson.HairLengthOrStyle;
        TxtEyeColour.Text = _missingPerson.EyeColour;
        TxtHeight.Text = _missingPerson.Height.ToString();
        TxtWeight.Text = _missingPerson.Weight.ToString();
        TxtMarksTattoos.Text = _missingPerson.MarksTattoos;

        //Disappearance Details
        TxtLastSeenWearing.Text = _missingPerson.LastSeenWearing;
        TxtLocationLastSeen.Text = _missingPerson.LocationLastSeen;
        TxtDateWentMissing.Text = _missingPerson.DateWentMissing;

        //Police Report
        TxtPoliceStation.Text = _missingPerson.PoliceStation;
        TxtCaseNumber.Text = _missingPerson.CaseNumber;
        TxtInvestigatingOfficer.Text = _missingPerson.InvestigatingOfficer;
        TxtInvestigatingOfficerContactNumber.Text = _missingPerson.InvestigatingOfficerContactNumber;

        //Family Contact
        TxtFamilyContactName.Text = _missingPerson.FamilyContactName;
        TxtFamilyContactNumber.Text = _missingPerson.FamilyContactNumber;

        //Missing Person Photo
        await LoadImageFromUrl(_missingPerson.ImageUrl);
    }

    private async Task LoadImageFromUrl(string imageUrl)
    {
        try
        {
            using var client = new HttpClient();

            var imageBytes = await client.GetByteArrayAsync(imageUrl);

            using var ms = new MemoryStream(imageBytes);

            PicPreview.Image = Image.FromStream(ms);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Failed to load image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}