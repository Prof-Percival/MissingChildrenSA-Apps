namespace MissingChildrenSA.Pages;

public partial class MissingPersonDetailPage : ContentPage
{
	public MissingPersonDetailPage(MissingPersonDetailPageModel model)
	{
		InitializeComponent();

		BindingContext = model;
    }
}