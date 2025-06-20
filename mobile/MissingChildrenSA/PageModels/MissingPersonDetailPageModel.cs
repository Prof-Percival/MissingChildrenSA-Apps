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
        if (query.TryGetValue("model", out var modelObject) && modelObject != null)
        {
            var modelString = modelObject.ToString();

            // Decode the URI-encoded string
            string decodedModel = Uri.UnescapeDataString(modelString);

            MissingPerson = System.Text.Json.JsonSerializer.Deserialize<MissingPersonModel>(decodedModel);
        }
    }

    [RelayCommand]
    private static Task ReportMissingPerson()
        => Shell.Current.GoToAsync($"reportmissingperson");
}