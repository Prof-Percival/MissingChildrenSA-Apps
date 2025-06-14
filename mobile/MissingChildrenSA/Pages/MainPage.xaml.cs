namespace MissingChildrenSA.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly ApiClient _apiClient;

        public MainPage(MainPageModel model, ApiClient apiClient)
        {
            InitializeComponent();
            BindingContext = model;
            _apiClient = apiClient;

            //call FetchDashboardStats on page load
            Appearing += async (s, e) =>
            {
                await FetchDashboardStats();
            };
        }

        private async Task FetchDashboardStats()
        {
            try
            {
                var stats = await _apiClient.GetMissingPersonsStatisticsAsync();

                if (stats != null)
                {
                    throw new Exception();
                    // Update the UI with the fetched stats
                    // For example, you can bind these stats to labels or charts in your XAML
                }
            }
            catch (Exception ex)
            {
                await AppShell.DisplaySnackbarAsync($"Error fetching dashboard stats: {ex.Message}");

                await Task.Delay(3000);

                await AppShell.DisplayToastAsync($"Error fetching dashboard stats: {ex.Message}");
            }
        }
    }
}