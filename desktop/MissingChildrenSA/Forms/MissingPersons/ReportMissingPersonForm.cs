﻿using MissingChildrenSA.Events;
using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Helpers.Images;
using MissingChildrenSA.Helpers.Validations;

namespace MissingChildrenSA.Forms.MissingPersons;

public partial class ReportMissingPersonForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    private string _selectedImagePath;

    public event EventHandler PersonReportedEventHandler;

    public ReportMissingPersonForm(
        EnumLoader enumLoader,
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
        _enumLoader = enumLoader;
    }

    private void ReportMissingPersonForm_Load(object sender, EventArgs e)
    {
        DtpDateOfBirth.MaxDate = DateTime.Now.Date;
        DtpDateOfBirth.Value = DateTime.Now.Date;
        DtpDateWentMissing.MaxDate = DateTime.Now.Date;
        DtpDateWentMissing.Value = DateTime.Now.Date;

        PopulateDropdowns();
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

    private async void BtnSubmit_Click(object sender, EventArgs e)
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
           (TxtInvestigatingOfficerContactNumber, "Investigating Officer Contact", c => !string.IsNullOrWhiteSpace(c.Text), "Contact Number is required."),
           (PicPreview, "Image", c => PicPreview.Image != null, "Please select an image.")
        );

        if (!isValid) return;

        if (string.IsNullOrWhiteSpace(_selectedImagePath) || !File.Exists(_selectedImagePath))
        {
            MessageBox.Show("Please upload a valid image file before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Upload image
            using var stream = File.OpenRead(_selectedImagePath);

            var fileParam = new FileParameter(stream, Path.GetFileName(_selectedImagePath), ImageExtensionHelper.GetContentType(_selectedImagePath));

            var imageMetadata = await _apiClient.UploadImageAsync(fileParam);

            if (string.IsNullOrWhiteSpace(imageMetadata?.FileUrl))
            {
                MessageBox.Show("Image upload failed. Please try again.", "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var request = new CreateMissingPersonRequest
            {
                FirstName = TxtName.Text,
                LastName = TxtSurname.Text,
                DateOfBirth = DtpDateOfBirth.Value,
                Gender = (Gender)CmbGender.SelectedIndex,
                Race = (Race)CmbRace.SelectedIndex,
                Province = (Province)CmbProvince.SelectedIndex,
                DateWentMissing = DtpDateWentMissing.Value,
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
                ImageUrl = imageMetadata.FileUrl
            };

            var response = await _apiClient.ReportMissingPersonAsync(request);

            PersonReportedEventHandler?.Invoke(this, EventArgs.Empty);

            EventAggregator.Instance.Publish(new AppEvents.MissingPersonCreatedOrUpdatedEvent());

            MessageBox.Show("Missing person reported successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
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

    private void ClearForm()
    {
        TxtName.Clear();
        TxtSurname.Clear();
        DtpDateOfBirth.Value = DateTime.Now.Date;
        CmbGender.SelectedIndex = 0;
        CmbRace.SelectedIndex = 0;
        CmbProvince.SelectedIndex = 0;
        DtpDateWentMissing.Value = DateTime.Now.Date;

        TxtHairColour.Clear();
        TxtHairLengthOrStyle.Clear();
        TxtEyeColour.Clear();
        NupHeight.Value = NupHeight.Minimum;
        NupWeight.Value = NupWeight.Minimum;
        TxtMarksTattoos.Clear();
        TxtLastSeenWearing.Clear();
        TxtLocationLastSeen.Clear();

        TxtPoliceStation.Clear();
        TxtCaseNumber.Clear();
        TxtInvestigatingOfficer.Clear();
        TxtInvestigatingOfficerContactNumber.Clear();

        TxtFamilyContactName.Clear();
        TxtFamilyContactNumber.Clear();

        PicPreview.Image = null;
        _selectedImagePath = null;

        TxtName.Focus();
    }
}