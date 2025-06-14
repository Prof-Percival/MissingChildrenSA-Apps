using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MissingChildrenSA.Models;
using System.Collections.ObjectModel;

namespace MissingChildrenSA.PageModels
{
    public partial class MainPageModel : ObservableObject, IProjectTaskPageModel
    {
        private bool _isNavigatedTo;
        private bool _dataLoaded;
        private readonly ProjectRepository _projectRepository;
        private readonly TaskRepository _taskRepository;
        private readonly CategoryRepository _categoryRepository;
        private readonly ModalErrorHandler _errorHandler;
        private readonly SeedDataService _seedDataService;
        private readonly ApiClient _apiClient;

        [ObservableProperty]
        private List<CategoryChartData> _todoCategoryData = [];

        [ObservableProperty]
        private List<Brush> _todoCategoryColors = [];

        [ObservableProperty]
        private List<ProjectTask> _tasks = [];

        [ObservableProperty]
        private List<Project> _projects = [];

        [ObservableProperty]
        bool _isBusy;

        [ObservableProperty]
        bool _isRefreshing;

        [ObservableProperty]
        private string _today = DateTime.Now.ToString("dddd, dd MMM yyyy");

        public bool HasCompletedTasks
            => Tasks?.Any(t => t.IsCompleted) ?? false;

        [ObservableProperty]
        private MissingPersonsStats missingPersonsStats;

        [ObservableProperty]
        private ObservableCollection<ProvinceCount> provinceStats = [];

        [ObservableProperty]
        private ObservableCollection<Brush> provincePalette;

        public MainPageModel(SeedDataService seedDataService, ProjectRepository projectRepository,
            TaskRepository taskRepository, CategoryRepository categoryRepository, ModalErrorHandler errorHandler,
            ApiClient apiClient)
        {
            _projectRepository = projectRepository;
            _taskRepository = taskRepository;
            _categoryRepository = categoryRepository;
            _errorHandler = errorHandler;
            _seedDataService = seedDataService;
            _apiClient = apiClient;

            ProvincePalette = [
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

            /*
                ProvincePalette = new ObservableCollection<Brush> {
                Brush.FromArgb("#4682B4"), // SteelBlue
                Brush.FromArgb("#008080"), // Teal
                Brush.FromArgb("#CD5C5C"), // IndianRed
                Brush.FromArgb("#FF8C00"), // DarkOrange
                Brush.FromArgb("#006400"), // DarkGreen
                Brush.FromArgb("#9370DB"), // MediumPurple
                Brush.FromArgb("#5F9EA0"), // CadetBlue
                Brush.FromArgb("#DAA520"), // Goldenrod
                Brush.FromArgb("#708090"), // SlateGray
                }; 
            */
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

                Projects = await _projectRepository.ListAsync();

                var chartData = new List<CategoryChartData>();
                var chartColors = new List<Brush>();

                var categories = await _categoryRepository.ListAsync();
                foreach (var category in categories)
                {
                    chartColors.Add(category.ColorBrush);

                    var ps = Projects.Where(p => p.CategoryID == category.ID).ToList();
                    int tasksCount = ps.SelectMany(p => p.Tasks).Count();

                    chartData.Add(new(category.Title, tasksCount));
                }

                TodoCategoryData = chartData;
                TodoCategoryColors = chartColors;

                Tasks = await _taskRepository.ListAsync();

                await LoadMissingPersonsDataAsync();
            }
            finally
            {
                IsBusy = false;
                OnPropertyChanged(nameof(HasCompletedTasks));
            }
        }

        private async Task InitData(SeedDataService seedDataService)
        {
            bool isSeeded = Preferences.Default.ContainsKey("is_seeded");

            if (!isSeeded)
            {
                await seedDataService.LoadSeedDataAsync();
            }

            Preferences.Default.Set("is_seeded", true);
            await Refresh();
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
                await InitData(_seedDataService);
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
        private Task<int> TaskCompleted(ProjectTask task)
        {
            OnPropertyChanged(nameof(HasCompletedTasks));
            return _taskRepository.SaveItemAsync(task);
        }

        [RelayCommand]
        private static Task AddTask()
            => Shell.Current.GoToAsync($"task");

        [RelayCommand]
        private Task NavigateToProject(Project project)
            => Shell.Current.GoToAsync($"project?id={project.ID}");

        [RelayCommand]
        private Task NavigateToTask(ProjectTask task)
            => Shell.Current.GoToAsync($"task?id={task.ID}");

        [RelayCommand]
        private async Task CleanTasks()
        {
            var completedTasks = Tasks.Where(t => t.IsCompleted).ToList();
            foreach (var task in completedTasks)
            {
                await _taskRepository.DeleteItemAsync(task);
                Tasks.Remove(task);
            }

            OnPropertyChanged(nameof(HasCompletedTasks));
            Tasks = new(Tasks);
            await AppShell.DisplayToastAsync("All cleaned up!");
        }
    }
}