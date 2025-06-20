using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MissingChildrenSA.Models;

namespace MissingChildrenSA.PageModels;

public partial class MissingPersonListPageModel : ObservableObject
{
    private readonly ApiClient _apiClient;

    [ObservableProperty]
    private List<MissingPersonModel> _missingPersons = [];

    public MissingPersonListPageModel(ApiClient apiClient)
    {
        _apiClient = apiClient;
    }

    [RelayCommand]
    private async Task Appearing()
    {
        var response = await _apiClient.FetchApprovedMissingPersonsAsync(1, 10);

        MissingPersons = [.. response.MissingPersons.Select(m => new MissingPersonModel(m))];
    }

    [RelayCommand]
    static Task NavigateToMissingPerson(MissingPersonModel missingPerson)
            => Shell.Current.GoToAsync($"missingperson?id={missingPerson.Id}");

    [RelayCommand]
    static async Task ReportMissingPerson()
    {
        await Shell.Current.GoToAsync($"reportmissingperson");
    }
}