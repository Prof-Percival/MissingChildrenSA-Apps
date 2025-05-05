using MissingChildrenSA.Helpers.Enums;

namespace MissingChildrenSA.Forms.Users;
public partial class CreateUserForm : Form
{
    private readonly EnumLoader _enumLoader;
    public CreateUserForm(EnumLoader enumLoader)
    {
        InitializeComponent();

        _enumLoader = enumLoader;
    }

    private void CreateUserForm_Load(object sender, EventArgs e)
    {
        LoadUserRolesDropdown();
    }

    private void LoadUserRolesDropdown()
    {
        CmbUserRole.Items.Clear();

        CmbUserRole.Items.Add("");

        CmbUserRole.Items.AddRange(_enumLoader.UserRoles.Select(ur => ur.Description).ToArray());
    }
}