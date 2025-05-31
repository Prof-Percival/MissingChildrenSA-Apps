using MissingChildrenSA.Models;
using MissingChildrenSA.PageModels;

namespace MissingChildrenSA.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}