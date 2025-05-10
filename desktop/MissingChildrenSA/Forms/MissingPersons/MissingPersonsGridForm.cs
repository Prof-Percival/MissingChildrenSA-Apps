using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Forms.Users;
using System.Data;

namespace MissingChildrenSA.Forms.MissingPersons;

public partial class MissingPersonsGridForm : Form
{
    private List<Models.MissingPersons.MissingPersonModel> _missingPersons = [];
    internal Models.MissingPersons.MissingPersonModel _selectedMissingPerson;

    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    public MissingPersonsGridForm(
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
    }

    private async void MissingPersonsGridForm_Load(object sender, EventArgs e)
    {
        await LoadMissingPersonsAsync();
    }

    private async Task LoadMissingPersonsAsync()
    {
        try
        {
            var response = await _apiClient.ListMissingPersonsAsync(1, int.MaxValue); //Change page size for pagination and not load everything

            _missingPersons = response.MissingPersons.Select(person => new Models.MissingPersons.MissingPersonModel(person)).ToList();

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
        DgvMissingPersons.Rows.Clear();

        foreach (var person in _missingPersons)
        {
            DgvMissingPersons.Rows.Add(
                person.Id,
                person.FirstName,
                person.LastName,
                person.Gender,
                person.Province,
                person.Created,
                person.Updated,
                person.LastEditedByUserId
            );
        }
    }

    private void DgvMissingPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Make sure the row index is valid
        if (e.RowIndex < 0)
            return;

        var row = DgvMissingPersons.Rows[e.RowIndex];

        // Extract the missing person id
        var id = int.Parse(row.Cells["DgvColId"].Value.ToString());

        _selectedMissingPerson = _missingPersons.Single(x => x.Id == id);

        if (DgvMissingPersons.Columns[e.ColumnIndex].Name == "DgvColEditButton")
        {
            //Show Edit Form
            using var editMissingPersonForm = _serviceProvider.GetRequiredService<EditMissingPersonForm>();

            editMissingPersonForm.PersonUpdatedEventHandler += async (s, e) => await LoadMissingPersonsAsync(); // Refresh missing persons when updated

            editMissingPersonForm.ShowDialog();
        }
    }

    private async void PicRefresh_Click(object sender, EventArgs e)
    {
        await LoadMissingPersonsAsync();
    }

    private void PicReportNow_Click(object sender, EventArgs e)
    {
        using var reportMissingPersonForm = _serviceProvider.GetRequiredService<ReportMissingPersonForm>();

        //reportMissingPersonForm.PersonReportedEventHandler += async (s, e) => await LoadMissingPersonsAsync(); // Refresh missing persons when added

        reportMissingPersonForm.ShowDialog();
    }
}