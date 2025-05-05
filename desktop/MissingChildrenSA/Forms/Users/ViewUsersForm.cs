using MissingChildrenSA.Models.Users;

namespace MissingChildrenSA.Forms.Users;

public partial class ViewUsersForm : Form
{
    private List<UserModel> _users = [];
    private UserModel _selectedUser;

    private readonly ApiClient _apiClient;

    public ViewUsersForm(ApiClient apiClient)
    {
        InitializeComponent();

        _apiClient = apiClient;
    }

    private async void ViewUsersForm_Load(object sender, EventArgs e)
    {
        MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        WindowState = FormWindowState.Maximized;

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
        var id = int.Parse(row.Cells["Id"].Value.ToString());

        var selectedUser = _users.Single(x => x.Id == id);

        if (DgvUsers.Columns[e.ColumnIndex].Name == "Edit")
        {
            MessageBox.Show($"Edit clicked for user: {selectedUser.Username}", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (DgvUsers.Columns[e.ColumnIndex].Name == "Delete")
        {
            MessageBox.Show($"Delete clicked for user: {selectedUser.Username}", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
