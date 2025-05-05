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
}
