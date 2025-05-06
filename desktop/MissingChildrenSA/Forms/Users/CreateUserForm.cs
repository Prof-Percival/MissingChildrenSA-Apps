using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Helpers.Validations;

namespace MissingChildrenSA.Forms.Users;
public partial class CreateUserForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly ApiClient _apiClient;

    public event EventHandler UserAddedEventHandler;

    public CreateUserForm(
        EnumLoader enumLoader,
        ApiClient apiClient)
    {
        InitializeComponent();

        _enumLoader = enumLoader;
        _apiClient = apiClient;
    }

    private void CreateUserForm_Load(object sender, EventArgs e)
    {
        LoadUserRolesDropdown();
    }

    private async void BtnAddUser_Click(object sender, EventArgs e)
    {
        bool isValid = FormValidator.ValidateMultiple(
            (TxtFirstName, "First Name", c => !string.IsNullOrWhiteSpace(c.Text), "First Name is required."),
            (TxtLastName, "Last Name", c => !string.IsNullOrWhiteSpace(c.Text), "Last Name is required."),
            (TxtUsername, "Username", c => !string.IsNullOrWhiteSpace(c.Text), "Username is required."),
            (TxtPassword, "Password", c => !string.IsNullOrWhiteSpace(c.Text), "Password is required."),
            (TxtPassword, "Password", c => c.Text.Length >= 6, "Password must be at least 6 characters."),
            (CmbUserRole, "User Role", c => CmbUserRole.SelectedIndex > 0, "Please select a user role."));

        if (!isValid) return;

        try
        {
            var request = new CreateUserRequest
            {
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                Username = TxtUsername.Text,
                Password = TxtPassword.Text,
                UserRole = (UserRole)CmbUserRole.SelectedIndex
            };

            var response = await _apiClient.Create2Async(request);

            UserAddedEventHandler?.Invoke(this, EventArgs.Empty);

            MessageBox.Show($"User Added Successfully!\n\n" +
                $"Id: {response.Id}\n" +
                $"Username: {response.Username}\n" +
                $"Full Name: {response.FullName}", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearForm();
        }
        catch (ApiException ex)
        {
            MessageBox.Show(ex.Message, "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LoadUserRolesDropdown()
    {
        CmbUserRole.Items.Clear();

        CmbUserRole.Items.Add("");

        CmbUserRole.Items.AddRange(_enumLoader.UserRoles.Select(ur => ur.Description).ToArray());
    }

    private void ClearForm()
    {
        TxtFirstName.Clear();
        TxtLastName.Clear();
        TxtUsername.Clear();
        TxtPassword.Clear();
        CmbUserRole.SelectedItem = null;

        TxtFirstName.Focus();

        LoadUserRolesDropdown();
    }
}