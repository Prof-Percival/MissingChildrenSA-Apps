using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Models.Users;

namespace MissingChildrenSA.Forms.Users;

public partial class ViewUsersForm : Form
{
    private List<UserModel> _users = [];
    internal UserModel _selectedUser;

    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    public ViewUsersForm(
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
    }

    private async void ViewUsersForm_Load(object sender, EventArgs e)
    {
        await LoadUsersAsync();
    }

    private async Task LoadUsersAsync()
    {
        try
        {
            var response = await _apiClient.ListAsync(1, int.MaxValue); //Change page size for pagination and not load everything

            _users = response.Users.Select(u => new UserModel(u)).ToList();

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
        DgvUsers.Rows.Clear();

        foreach (var user in _users)
        {
            DgvUsers.Rows.Add(
                user.Id,
                user.Username,
                user.FirstName,
                user.LastName,
                user.UserRole,
                user.Created,
                user.Updated
            );
        }
    }

    private void DgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Make sure the row index is valid
        if (e.RowIndex < 0)
            return;

        var row = DgvUsers.Rows[e.RowIndex];

        // Extract the username or any other info you want
        var id = int.Parse(row.Cells["DgvColId"].Value.ToString());

        _selectedUser = _users.Single(x => x.Id == id);

        if (DgvUsers.Columns[e.ColumnIndex].Name == "DgvColEditButton")
        {
            MessageBox.Show($"Edit clicked for user: {_selectedUser.Username}", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (DgvUsers.Columns[e.ColumnIndex].Name == "DgvColDeleteButton")
        {
            MessageBox.Show($"Delete clicked for user: {_selectedUser.Username}", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private async void PicRefresh_Click(object sender, EventArgs e)
    {
        await LoadUsersAsync();
    }

    private void PicAddUser_Click(object sender, EventArgs e)
    {
        using var createUserForm = _serviceProvider.GetRequiredService<CreateUserForm>();

        createUserForm.UserAddedEventHandler += async (s, e) => await LoadUsersAsync(); // Refresh users when added

        createUserForm.ShowDialog();
    }
}