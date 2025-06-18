namespace MissingChildrenSA.Pages;

public partial class MissingPersonPage : ContentPage
{
	public MissingPersonPage(MissingPersonPageModel model)
	{
		InitializeComponent();

        BindingContext = model;
	}
}