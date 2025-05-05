using MissingChildrenSA.Helpers.Enums;

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

    private void BtnAddUser_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TxtFirstName.Text))
        {
            MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TxtFirstName.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(TxtLastName.Text))
        {
            MessageBox.Show("Last Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TxtLastName.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(TxtUsername.Text))
        {
            MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TxtUsername.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(TxtPassword.Text))
        {
            MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            TxtPassword.Focus();
            return;
        }

        if (CmbUserRole.SelectedIndex <= 0)
        {
            MessageBox.Show("User Role must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CmbUserRole.Focus();
            return;
        }

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

            var response = _apiClient.Create2Async(request);

            UserAddedEventHandler?.Invoke(this, EventArgs.Empty);
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
}