using MissingChildrenSA.Helpers.Enums;

namespace MissingChildrenSA.Forms.MissingPersons;

public partial class ReportMissingPersonForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

    private string _selectedImagePath;

    public ReportMissingPersonForm(
        EnumLoader enumLoader,
        ApiClient apiClient,
        IServiceProvider serviceProvider)
    {
        InitializeComponent();

        _apiClient = apiClient;
        _serviceProvider = serviceProvider;
        _enumLoader = enumLoader;
    }

    private void ReportMissingPersonForm_Load(object sender, EventArgs e)
    {
        DtpDateOfBirth.MaxDate = DateTime.Now;

        PopulateDropdowns();
    }

    private void BtnUploadImage_Click(object sender, EventArgs e)
    {
        using var openFileDialog = new OpenFileDialog
        {
            Title = "Select Image",
            Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
            Multiselect = false
        };

        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            _selectedImagePath = openFileDialog.FileName;

            // Preview the image
            PicPreview.Image = Image.FromFile(_selectedImagePath);
        }
    }

    private void PopulateDropdowns()
    {
        //Genders
        CmbGender.Items.Clear();
        CmbGender.Items.Add("");
        CmbGender.Items.AddRange(_enumLoader.Genders.Select(ur => ur.Description).ToArray());

        //Races
        CmbRace.Items.Clear();
        CmbRace.Items.Add("");
        CmbRace.Items.AddRange(_enumLoader.Races.Select(ur => ur.Description).ToArray());

        //Provinces
        CmbProvince.Items.Clear();
        CmbProvince.Items.Add("");
        CmbProvince.Items.AddRange(_enumLoader.Provinces.Select(ur => ur.Description).ToArray());
    }
}