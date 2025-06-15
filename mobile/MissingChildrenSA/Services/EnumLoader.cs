namespace MissingChildrenSA.Services;

public sealed class EnumLoader
{
    public List<EnumValue> Genders { get; private set; } = [];
    public List<EnumValue> MissingPersonStatuses { get; private set; } = [];
    public List<EnumValue> ModerationStatuses { get; private set; } = [];
    public List<EnumValue> Provinces { get; private set; } = [];
    public List<EnumValue> Races { get; private set; } = [];

    public EnumLoader(
        ApiClient apiClient,
        ModalErrorHandler errorHandler)
    {
        LoadEnumsAsync(apiClient).FireAndForgetSafeAsync(errorHandler);
    }

    private async Task LoadEnumsAsync(ApiClient apiClient)
    {
        await LoadSafeAsync(apiClient.GendersAsync, values => Genders = values);
        await LoadSafeAsync(apiClient.MissingPersonStatusesAsync, values => MissingPersonStatuses = values);
        await LoadSafeAsync(apiClient.ModerationStatusesAsync, values => ModerationStatuses = values);
        await LoadSafeAsync(apiClient.ProvincesAsync, values => Provinces = values);
        await LoadSafeAsync(apiClient.RacesAsync, values => Races = values);
    }

    private async Task LoadSafeAsync(Func<Task<ICollection<EnumValueResponse>>> apiCall, Action<List<EnumValue>> assign)
    {
        var result = await apiCall();

        assign(result.Select(Map).ToList());
    }

    private EnumValue Map(EnumValueResponse enumValueResponse)
    {
        return new EnumValue(enumValueResponse);
    }
}

public sealed class EnumValue(EnumValueResponse enumValue)
{
    public int Id { get; } = enumValue.Id;
    public string Name { get; } = enumValue.Name;
    public string Description { get; } = enumValue.Description;
}