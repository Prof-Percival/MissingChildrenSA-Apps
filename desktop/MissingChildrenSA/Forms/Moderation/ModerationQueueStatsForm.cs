using MissingChildrenSA.Models.Moderation;

namespace MissingChildrenSA.Forms.Moderation;

public partial class ModerationQueueStatsForm : Form
{
    private readonly ApiClient _apiClient;

    private ModerationQueueStatsModel _queueStats;

    public ModerationQueueStatsForm(ApiClient apiClient)
    {
        InitializeComponent();
        _apiClient = apiClient;
    }

    private async void ModerationQueueStatsForm_Load(object sender, EventArgs e)
    {
        await LoadQueueStatsAsync();

        PopulateQueueStats();
    }

    private async Task LoadQueueStatsAsync()
    {
        try
        {
            var response = await _apiClient.GetModerationQueueStatsAsync();

            _queueStats = new ModerationQueueStatsModel(response);
        }
        catch (ApiException ex)
        {
            MessageBox.Show($"{ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void PopulateQueueStats()
    {
        LblUnmoderated.Text = _queueStats.Unmoderated.ToString();
        LblInModeration.Text = _queueStats.InModeration.ToString();
        LblFailed.Text = _queueStats.Failed.ToString();
        LblApproved.Text = _queueStats.Approved.ToString();
    }
}