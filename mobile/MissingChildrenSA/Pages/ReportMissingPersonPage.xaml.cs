namespace MissingChildrenSA.Pages;

public partial class ReportMissingPersonPage : ContentPage
{
	public ReportMissingPersonPage(ReportMissingPersonPageModel model)
	{
		InitializeComponent();

        BindingContext = model;
	}
}