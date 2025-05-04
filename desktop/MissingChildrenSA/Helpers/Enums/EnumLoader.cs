namespace MissingChildrenSA.Helpers.Enums;

public sealed class EnumLoader(
    ApiClient apiClient)
{
    public List<EnumValue> Genders { get; private set; } = [];
    public List<EnumValue> MissingPersonStatuses { get; private set; } = [];
    public List<EnumValue> ModerationStatuses { get; private set; } = [];
    public List<EnumValue> Provinces { get; private set; } = [];
    public List<EnumValue> Races { get; private set; } = [];
    public List<EnumValue> UserRoles { get; private set; } = [];

    public async Task LoadEnumsAsync()
    {
        await LoadSafeAsync(apiClient.GendersAsync, values => Genders = values);
        await LoadSafeAsync(apiClient.MissingPersonStatusesAsync, values => MissingPersonStatuses = values);
        await LoadSafeAsync(apiClient.ModerationStatusesAsync, values => ModerationStatuses = values);
        await LoadSafeAsync(apiClient.ProvincesAsync, values => Provinces = values);
        await LoadSafeAsync(apiClient.RacesAsync, values => Races = values);
        await LoadSafeAsync(apiClient.RolesAsync, values => UserRoles = values);
    }

    private async Task LoadSafeAsync(Func<Task<ICollection<EnumValueResponse>>> apiCall, Action<List<EnumValue>> assign)
    {
        try
        {
            var result = await apiCall();

            assign(result.Select(Map).ToList());
        }
        catch (ApiException ex)
        {
            MessageBox.Show($"Error loading enums: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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