using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Extensions.Logging;
using MissingChildrenSA.Models;

namespace MissingChildrenSA.PageModels;

public partial class MissingPersonDetailPageModel : ObservableObject, IQueryAttributable
{
    private readonly ILogger<MissingPersonDetailPageModel> _logger;
    private readonly ModalErrorHandler _errorHandler;

    [ObservableProperty]
    private MissingPersonModel _missingPerson;

    public MissingPersonDetailPageModel(
        ILogger<MissingPersonDetailPageModel> logger,
        ModalErrorHandler errorHandler)
    {
        _logger = logger;
        _errorHandler = errorHandler;
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("model", out var modelObject) && modelObject != null)
        {
            try
            {
                var modelString = modelObject.ToString();
                
                // Decode the URI-encoded string
                string decodedModel = Uri.UnescapeDataString(modelString);

                MissingPerson = System.Text.Json.JsonSerializer.Deserialize(decodedModel, JsonContext.Default.MissingPersonModel);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deserializing missing person data");

                _errorHandler.HandleError(ex);
            }
        }
    }

    [RelayCommand]
    private static Task ReportMissingPerson()
        => Shell.Current.GoToAsync($"reportmissingperson");
}