namespace MissingChildrenSA.Services;

public sealed class EnumLoader
{
    public List<EnumValue> Genders { get; private set; } = [];
    public List<EnumValue> MissingPersonStatuses { get; private set; } = [];
    public List<EnumValue> ModerationStatuses { get; private set; } = [];
    public List<EnumValue> Provinces { get; private set; } = [];
    public List<EnumValue> Races { get; private set; } = [];

    private readonly ApiClient _apiClient;
    private readonly ModalErrorHandler _errorHandler;

    public EnumLoader(ApiClient apiClient, ModalErrorHandler errorHandler)
    {
        _apiClient = apiClient;
        _errorHandler = errorHandler;
    }

    public async Task InitializeAsync()
    {
        await LoadEnumsAsync();
    }

    private async Task LoadEnumsAsync()
    {
        await LoadSafeAsync(_apiClient.GendersAsync, values => Genders = values);
        await LoadSafeAsync(_apiClient.MissingPersonStatusesAsync, values => MissingPersonStatuses = values);
        await LoadSafeAsync(_apiClient.ModerationStatusesAsync, values => ModerationStatuses = values);
        await LoadSafeAsync(_apiClient.ProvincesAsync, values => Provinces = values);
        await LoadSafeAsync(_apiClient.RacesAsync, values => Races = values);
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