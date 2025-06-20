using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MissingChildrenSA.Models;

namespace MissingChildrenSA.PageModels;

public partial class MissingPersonDetailPageModel : ObservableObject, IQueryAttributable
{
    [ObservableProperty]
    private MissingPersonModel _missingPerson;

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