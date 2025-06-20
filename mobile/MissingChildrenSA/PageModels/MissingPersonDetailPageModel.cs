using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MissingChildrenSA.Models;

namespace MissingChildrenSA.PageModels;

public partial class MissingPersonDetailPageModel : ObservableObject, IQueryAttributable
{
    private readonly ApiClient _apiClient;
    private readonly ModalErrorHandler _errorHandler;

    [ObservableProperty]
    private MissingPersonModel _missingPerson;

    [ObservableProperty]
    bool _isBusy;

    public MissingPersonDetailPageModel(
        ApiClient apiClient,
        ModalErrorHandler errorHandler)
    {
        _apiClient = apiClient;
        _errorHandler = errorHandler;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.ContainsKey("id"))
        {
            int id = Convert.ToInt32(query["id"]);

            LoadDetails(id).FireAndForgetSafeAsync(_errorHandler);
        }
    }

    [RelayCommand]
    private static Task ReportMissingPerson()
        => Shell.Current.GoToAsync($"reportmissingperson");

    private async Task LoadDetails(int id)
    {
        try
        {
            IsBusy = true;

            var missingPerson = await _apiClient.GetMissingPersonByIdAsync(id);
            
            MissingPerson = new MissingPersonModel(missingPerson);
        }
        catch (Exception ex)
        {
            _errorHandler.HandleError(ex);
        }
        finally
        {
            IsBusy = false;
        }
    }
}