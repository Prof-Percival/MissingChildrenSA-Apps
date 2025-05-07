using Microsoft.Extensions.DependencyInjection;
using MissingChildrenSA.Helpers.Enums;
using MissingChildrenSA.Models.Users;

namespace MissingChildrenSA.Forms.Users;

public partial class EditUserForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    private UserModel _user;

    public event EventHandler UserUpdatedEventHandler;

    public EditUserForm(
        EnumLoader enumLoader,
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _enumLoader = enumLoader;
        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
    }

    private void CreateUserForm_Load(object sender, EventArgs e)
    {
        LoadUserRolesDropdown();

        _user = _serviceProvider.GetRequiredService<ViewUsersForm>()._selectedUser;

        PrepopulateForm();
    }

    private async void BtnUpdateUser_Click(object sender, EventArgs e)
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

        if (CmbUserRole.SelectedIndex <= 0)
        {
            MessageBox.Show("User Role must be selected.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            CmbUserRole.Focus();
            return;
        }

        try
        {
            var request = new UpdateUserRequest
            {
                FirstName = TxtFirstName.Text,
                LastName = TxtLastName.Text,
                Password = string.IsNullOrWhiteSpace(TxtPassword.Text) ? null : TxtPassword.Text,
                UserRole = (UserRole)CmbUserRole.SelectedIndex
            };

            var response = await _apiClient.UpdateUserAsync(_user.Id, request);

            UserUpdatedEventHandler?.Invoke(this, EventArgs.Empty);

            MessageBox.Show($"User Updated Successfully!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void PrepopulateForm()
    {
        TxtFirstName.Text = _user.FirstName;
        TxtLastName.Text = _user.LastName;
        CmbUserRole.SelectedItem = CmbUserRole.Items[CmbUserRole.Items.IndexOf(_user.UserRole)];
    }
}