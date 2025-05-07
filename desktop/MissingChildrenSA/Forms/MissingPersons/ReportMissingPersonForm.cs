using MissingChildrenSA.Helpers.Enums;

namespace MissingChildrenSA.Forms.MissingPersons;

public partial class ReportMissingPersonForm : Form
{
    private readonly EnumLoader _enumLoader;
    private readonly ApiClient _apiClient;
    private readonly IServiceProvider _serviceProvider;

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

    private void PopulateDropdowns()
    {

    }
}