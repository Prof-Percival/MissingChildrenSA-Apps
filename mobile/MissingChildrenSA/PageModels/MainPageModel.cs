using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MissingChildrenSA.Models;
using System.Collections.ObjectModel;

namespace MissingChildrenSA.PageModels
{
    public partial class MainPageModel : ObservableObject
    {
        private bool _isNavigatedTo;
        private bool _dataLoaded;
        private readonly ModalErrorHandler _errorHandler;
        private readonly ApiClient _apiClient;

        [ObservableProperty]
        bool _isBusy;

        [ObservableProperty]
        bool _isRefreshing;

        [ObservableProperty]
        private string _today = DateTime.Now.ToString("dddd, dd MMM yyyy");

        [ObservableProperty]
        private MissingPersonsStats missingPersonsStats;

        [ObservableProperty]
        private ObservableCollection<ProvinceCount> provinceStats = [];

        [ObservableProperty]
        private ObservableCollection<Brush> provincePalette =
        [
            Brush.SteelBlue,
            Brush.Teal,
            Brush.IndianRed,
            Brush.DarkOrange,
            Brush.DarkGreen,
            Brush.MediumPurple,
            Brush.CadetBlue,
            Brush.Goldenrod,
            Brush.SlateGray,
        ];

        public MainPageModel(
            ModalErrorHandler errorHandler,
            ApiClient apiClient,
            EnumLoader enumLoader)
        {
            _errorHandler = errorHandler;
            _apiClient = apiClient;

            enumLoader.InitializeAsync().FireAndForgetSafeAsync();
        }

        private async Task LoadMissingPersonsDataAsync()
        {
            try
            {
                var stats = await _apiClient.GetMissingPersonsStatisticsAsync();

                MissingPersonsStats = new MissingPersonsStats
                {
                    RecentlyReported = stats.MissingPersonsStats.RecentlyReported,
                    TotalReported = stats.MissingPersonsStats.TotalReported,
                    Males = stats.MissingPersonsStats.Males,
                    Females = stats.MissingPersonsStats.Females
                };

                ProvinceStats.Clear();

                foreach (var p in stats.StatsByProvince)
                {
                    ProvinceStats.Add(new ProvinceCount { Province = p.Province, Count = p.Count });
                }
            }
            catch (Exception e)
            {
                _errorHandler.HandleError(e);
            }
        }

        private async Task LoadData()
        {
            try
            {
                IsBusy = true;

                await LoadMissingPersonsDataAsync();
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task Refresh()
        {
            try
            {
                IsRefreshing = true;
                await LoadData();
            }
            catch (Exception e)
            {
                _errorHandler.HandleError(e);
            }
            finally
            {
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        private void NavigatedTo() =>
            _isNavigatedTo = true;

        [RelayCommand]
        private void NavigatedFrom() =>
            _isNavigatedTo = false;

        [RelayCommand]
        private async Task Appearing()
        {
            if (!_dataLoaded)
            {
                _dataLoaded = true;
                await Refresh();
            }
            // This means we are being navigated to
            else if (!_isNavigatedTo)
            {
                await Refresh();
            }
        }

        [RelayCommand]
        private static Task ReportMissingPerson()
            => Shell.Current.GoToAsync($"reportmissingperson");
    }
}