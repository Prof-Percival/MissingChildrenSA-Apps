using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Helpers.Enums;

namespace MissingChildrenSA.Forms.Moderation;

public partial class ModerateMissingPersonForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    private Models.Moderation.ModerationQueueItem _selectedModerationQueueItem;
    private Models.MissingPersons.MissingPersonModel _missingPerson;

    public event EventHandler ModerationStartedEventHandler;
    public event EventHandler ModerationFormClosedEventHandler;

    public ModerateMissingPersonForm(
        EnumLoader enumLoader,
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
        _enumLoader = enumLoader;
    }

    private async void ModerateMissingPersonForm_Load(object sender, EventArgs e)
    {
        _selectedModerationQueueItem = _serviceProvider.GetRequiredService<ModerationQueueForm>()._selectedModerationQueueItem;

        if (_selectedModerationQueueItem.ModeratedByUserId.HasValue)
        {
            //Moderation has started. Hide Start Moderation button
            BtnStartModeration.Visible = false;
        }

        if (_selectedModerationQueueItem.ModerationStatus != "Failed" &&
            _selectedModerationQueueItem.ModerationStatus != "Approved")
        {
            //Moderation is not complete. Show this section
            GrpModeration.Visible = true;
        }
        else
        {
            //Moderation has been completed. Hide this section
            GrpModeration.Visible = false;
        }

        await FetchMissingPersonDetailsAsync();

        await PopulateFormAsync();
    }

    private async void BtnStartModeration_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show("Are you sure you want to start moderation on this item?", "Moderation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.No) return;

        try
        {
            await _apiClient.StartModerationAsync(_selectedModerationQueueItem.Id);

            ModerationStartedEventHandler?.Invoke(this, EventArgs.Empty);

            BtnStartModeration.Visible = false;
            GrpModeration.Visible = true;
        }
        catch (ApiException ex)
        {
            MessageBox.Show($"API Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private async void BtnApprove_Click(object sender, EventArgs e)
    {
        var dialogResult = MessageBox.Show("Are You Sure You Want To Approve This Item?", "Moderation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.No) return;

        try
        {
            await UpdateModerationStatusAsync("Approved");

            ModerationStartedEventHandler?.Invoke(this, EventArgs.Empty);

            BtnStartModeration.Visible = false;
            GrpModeration.Visible = false;
        }
        catch (ApiException ex)
        {
            MessageBox.Show($"API Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ModerateMissingPersonForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        ModerationFormClosedEventHandler?.Invoke(this, EventArgs.Empty);
    }

    private async Task UpdateModerationStatusAsync(string status, string reason = null)
    {
        var request = new ModerationStatusUpdateRequest
        {
            QueueItemId = _selectedModerationQueueItem.Id,
            Status = (ModerationStatus)_enumLoader.ModerationStatuses.Single(x => x.Description == status).Id,
            Reason = reason
        };

        await _apiClient.UpdateModerationStatusAsync(request);
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

    private async Task FetchMissingPersonDetailsAsync()
    {
        try
        {
            var details = await _apiClient.GetQueueDetailsAsync(_selectedModerationQueueItem.Id);

            _missingPerson = new Models.MissingPersons.MissingPersonModel(details.MissingPerson);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}