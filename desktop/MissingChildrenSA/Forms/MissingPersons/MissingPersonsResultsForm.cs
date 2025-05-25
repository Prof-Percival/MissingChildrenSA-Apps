using Microsoft.Extensions.DependencyInjection;

namespace MissingChildrenSA.Forms.MissingPersons;

public partial class MissingPersonsResultsForm : Form
{
    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    private int _currentPage = 1;
    private const int PageSize = 20;

    public Models.MissingPersons.MissingPersonModel _selectedMissingPerson;

    public MissingPersonsResultsForm(
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
    }

    private async void MissingPersonsResultsForm_Load(object sender, EventArgs e)
    {
        await LoadPage(_currentPage);
    }

    private async Task LoadPage(int pageNumber)
    {
        var result = await _apiClient.ListMissingPersonsAsync(pageNumber, PageSize);

        var missingPersons = result.MissingPersons.Select(p => new Models.MissingPersons.MissingPersonModel(p));

        FlowLayoutPanelTiles.Controls.Clear();

        foreach (var person in missingPersons)
        {
            var tile = new MissingPersonTileControl
            {
                Width = 200,
                Height = 260
            };

            await tile.SetData(person);

            tile.TileClicked += Tile_TileClicked;

            FlowLayoutPanelTiles.Controls.Add(tile);
        }

        BtnPrev.Enabled = pageNumber > 1;
        BtnNext.Enabled = result.TotalCount > pageNumber * PageSize;
    }

    private void Tile_TileClicked(object sender, EventArgs e)
    {
        if (sender is MissingPersonTileControl tile)
        {
            _selectedMissingPerson = tile.MissingPerson;

            var missingPersonForm = _serviceProvider.GetRequiredService<MissingPersonForm>();

            missingPersonForm.ShowDialog();
        }
    }

    private async void BtnNext_Click(object sender, EventArgs e)
    {
        _currentPage++;

        await LoadPage(_currentPage);
    }

    private async void BtnPrev_Click(object sender, EventArgs e)
    {
        if (_currentPage > 1)
        {
            _currentPage--;

            await LoadPage(_currentPage);
        }
    }
}