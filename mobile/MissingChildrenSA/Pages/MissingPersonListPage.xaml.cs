namespace MissingChildrenSA.Pages;

public partial class MissingPersonListPage : ContentPage
{
	public MissingPersonListPage(MissingPersonListPageModel model)
	{
		BindingContext = model;
        InitializeComponent();
	}
}