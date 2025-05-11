using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Helpers.Images;
using MissingChildrenSA.Helpers.Validations;
using System.Globalization;

namespace MissingChildrenSA.Forms.MissingPersons;

public partial class EditMissingPersonForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    private Models.MissingPersons.MissingPersonModel _missingPerson;
    private string _selectedImagePath;

    public event EventHandler PersonUpdatedEventHandler;

    public EditMissingPersonForm(
        EnumLoader enumLoader,
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
        _enumLoader = enumLoader;
    }

    private async void EditMissingPersonForm_Load(object sender, EventArgs e)
    {
        DtpDateOfBirth.MaxDate = DateTime.Now.Date;
        DtpDateWentMissing.MaxDate = DateTime.Now.Date;

        PopulateDropdowns();

        _missingPerson = _serviceProvider.GetRequiredService<MissingPersonsGridForm>()._selectedMissingPerson;

        await PrepopulateForm();
    }

    private void BtnUploadImage_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog
        {
            Title = "Select Image",
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
            Multiselect = false
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _selectedImagePath = openFileDialog.FileName;

            // Preview the image
            PicPreview.Image = Image.FromFile(_selectedImagePath);
        }
    }

    private async void BtnUpdate_Click(object sender, EventArgs e)
    {
        bool isValid = FormValidator.ValidateMultiple(
           (TxtName, "Name", c => !string.IsNullOrWhiteSpace(c.Text), "Name is required."),
           (TxtSurname, "Surname", c => !string.IsNullOrWhiteSpace(c.Text), "Surname is required."),
           (CmbGender, "Gender", c => CmbGender.SelectedIndex > 0, "Please select a gender."),
           (CmbRace, "Race", c => CmbRace.SelectedIndex > 0, "Please select a race."),
           (CmbProvince, "Province", c => CmbProvince.SelectedIndex > 0, "Please select a province."),
           (TxtHairColour, "Hair Colour", c => !string.IsNullOrWhiteSpace(c.Text), "Hair Colour is required."),
           (TxtHairLengthOrStyle, "Hair Length / Style", c => !string.IsNullOrWhiteSpace(c.Text), "Hair Length / Style is required."),
           (TxtEyeColour, "Eye Colour", c => !string.IsNullOrWhiteSpace(c.Text), "Eye Colour is required."),
           (NupHeight, "Height", c => NupHeight.Value > 0, "Height must be greater than 0."),
           (NupWeight, "Weight", c => NupWeight.Value > 0, "Weight must be greater than 0."),
           (TxtPoliceStation, "Police Station", c => !string.IsNullOrWhiteSpace(c.Text), "Police Station is required."),
           (TxtCaseNumber, "Case Number", c => !string.IsNullOrWhiteSpace(c.Text), "Case Number is required."),
           (TxtInvestigatingOfficer, "Investigating Officer", c => !string.IsNullOrWhiteSpace(c.Text), "Investigating Officer is required."),
           (TxtInvestigatingOfficerContactNumber, "Investigating Officer Contact", c => !string.IsNullOrWhiteSpace(c.Text), "Contact Number is required.")
        );

        if (!isValid) return;

        if (string.IsNullOrWhiteSpace(_selectedImagePath) || !File.Exists(_selectedImagePath))
        {
            MessageBox.Show("Please upload a valid image file before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Upload image if it has changed
            string imageUrl = null;

            if (!string.IsNullOrWhiteSpace(_selectedImagePath))
            {
                using var stream = File.OpenRead(_selectedImagePath);

                var fileParam = new FileParameter(stream, Path.GetFileName(_selectedImagePath), ImageExtensionHelper.GetContentType(_selectedImagePath));

                var imageMetadata = await _apiClient.UploadImageAsync(fileParam);

                if (string.IsNullOrWhiteSpace(imageMetadata?.FileUrl))
                {
                    MessageBox.Show("Image upload failed. Please try again.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                imageUrl = imageMetadata.FileUrl;
            }

            var request = new UpdateMissingPersonRequest
            {
                Id = _missingPerson.Id,
                FirstName = TxtName.Text,
                LastName = TxtSurname.Text,
                DateOfBirth = new DateTimeOffset(DtpDateOfBirth.Value, TimeZoneInfo.Local.GetUtcOffset(DtpDateOfBirth.Value)),
                Gender = (Gender)CmbGender.SelectedIndex,
                Race = (Race)CmbRace.SelectedIndex,
                Province = (Province)CmbProvince.SelectedIndex,
                DateWentMissing = new DateTimeOffset(DtpDateWentMissing.Value, TimeZoneInfo.Local.GetUtcOffset(DtpDateWentMissing.Value)),
                HairColour = TxtHairColour.Text,
                HairLengthOrStyle = TxtHairLengthOrStyle.Text,
                EyeColour = TxtEyeColour.Text,
                Height = (int)NupHeight.Value,
                Weight = (double)NupWeight.Value,
                MarksTattoos = TxtMarksTattoos.Text,
                LastSeenWearing = TxtLastSeenWearing.Text,
                LocationLastSeen = TxtLocationLastSeen.Text,
                PoliceStation = TxtPoliceStation.Text,
                CaseNumber = TxtCaseNumber.Text,
                InvestigatingOfficer = TxtInvestigatingOfficer.Text,
                InvestigatingOfficerContactNumber = TxtInvestigatingOfficerContactNumber.Text,
                FamilyContactName = TxtFamilyContactName.Text,
                FamilyContactNumber = TxtFamilyContactNumber.Text,
                ImageUrl = imageUrl ?? _missingPerson.ImageUrl
            };

            await _apiClient.UpdateMissingPersonAsync(request);

            PersonUpdatedEventHandler?.Invoke(this, EventArgs.Empty);

            MessageBox.Show("Missing person updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (ApiException ex)
        {
            MessageBox.Show($"API Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PopulateDropdowns()
    {
        //Genders
        CmbGender.Items.Clear();
        CmbGender.Items.Add("");
        CmbGender.Items.AddRange(_enumLoader.Genders.Select(ur => ur.Description).ToArray());

        //Races
        CmbRace.Items.Clear();
        CmbRace.Items.Add("");
        CmbRace.Items.AddRange(_enumLoader.Races.Select(ur => ur.Description).ToArray());

        //Provinces
        CmbProvince.Items.Clear();
        CmbProvince.Items.Add("");
        CmbProvince.Items.AddRange(_enumLoader.Provinces.Select(ur => ur.Description).ToArray());
    }

    private async Task PrepopulateForm()
    {
        //Personal Details
        TxtName.Text = _missingPerson.FirstName;
        TxtSurname.Text = _missingPerson.LastName;
        ParseAndSetDate(DtpDateOfBirth, _missingPerson.DateOfBirth);
        SetSelectedItem(CmbGender, _missingPerson.Gender);
        SetSelectedItem(CmbRace, _missingPerson.Race);
        SetSelectedItem(CmbProvince, _missingPerson.Province);

        //Physical Description
        TxtHairColour.Text = _missingPerson.HairColour;
        TxtHairLengthOrStyle.Text = _missingPerson.HairLengthOrStyle;
        TxtEyeColour.Text = _missingPerson.EyeColour;
        NupHeight.Value = _missingPerson.Height;
        NupWeight.Value = (decimal)_missingPerson.Weight;
        TxtMarksTattoos.Text = _missingPerson.MarksTattoos;

        //Disappearance Details
        TxtLastSeenWearing.Text = _missingPerson.LastSeenWearing;
        TxtLocationLastSeen.Text = _missingPerson.LocationLastSeen;
        ParseAndSetDate(DtpDateWentMissing, _missingPerson.DateWentMissing, includeTime: true);

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

    private static void ParseAndSetDate(
        DateTimePicker control,
        string date,
        bool includeTime = false)
    {
        try
        {
            var formats = new string[] {
                "dd/MM/yyyy HH:mm",      // date and short time
                "dd/MM/yyyy"             // just date
            };

            if (DateTime.TryParseExact(date, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var parsedDateTime))
            {
                control.Value = includeTime ? parsedDateTime : parsedDateTime.Date;
            }
        }
        catch (Exception)
        {
            // Silently fail
        }
    }

    private static void SetSelectedItem(ComboBox control, string value)
    {
        try
        {
            control.SelectedItem = control.Items[control.Items.IndexOf(value)];
        }
        catch (Exception)
        {
            //don't do anything
        }
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