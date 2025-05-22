using System.Data;

namespace MissingChildrenSA.Forms.Moderation;

public partial class ModerationQueueForm : Form
{
    private List<Models.Moderation.ModerationQueueItem> _moderationQueueItems = [];
    internal Models.Moderation.ModerationQueueItem _selectedModerationQueueItem;

    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    public ModerationQueueForm(
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
    }

    private async void ModerationQueueForm_Load(object sender, EventArgs e)
    {
        await LoadModerationQueueItemsAsync();
    }

    private async Task LoadModerationQueueItemsAsync()
    {
        try
        {
            var response = await _apiClient.GetModerationQueueAsync(1, int.MaxValue); //Change page size for pagination and not load everything

            _moderationQueueItems = response.Items.Select(item => new Models.Moderation.ModerationQueueItem(item)).ToList();
        }
        catch (ApiException ex)
        {
            MessageBox.Show($"{ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            PopulateGrid();
        }
    }

    private void PopulateGrid()
    {
        DgvModerationQueue.Rows.Clear();

        foreach (var queueItem in _moderationQueueItems)
        {
            DgvModerationQueue.Rows.Add(
                queueItem.Id,
                queueItem.Created,
                queueItem.Updated,
                queueItem.ModeratedByUserId,
                queueItem.MissingPersonId,
                queueItem.ModerationStatus,
                queueItem.ModerationStatusReason
            );
        }
    }

    private void DgvModerationQueue_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Make sure the row index is valid
        if (e.RowIndex < 0)
            return;

        var row = DgvModerationQueue.Rows[e.RowIndex];

        // Extract the Moderation Queue Item id
        var id = int.Parse(row.Cells["DgvColId"].Value.ToString());

        _selectedModerationQueueItem = _moderationQueueItems.Single(x => x.Id == id);

        if (DgvModerationQueue.Columns[e.ColumnIndex].Name == "DgvColViewButton")
        {
            //Show View Form
        }
    }

    private async void PicRefresh_Click(object sender, EventArgs e)
    {
        await LoadModerationQueueItemsAsync();
    }
}