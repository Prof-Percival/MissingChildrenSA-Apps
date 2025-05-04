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
        Genders = (await apiClient.GendersAsync()).Select(Map).ToList();
        MissingPersonStatuses = (await apiClient.MissingPersonStatusesAsync()).Select(Map).ToList();
        ModerationStatuses = (await apiClient.ModerationStatusesAsync()).Select(Map).ToList();
        Provinces = (await apiClient.ProvincesAsync()).Select(Map).ToList();
        Races = (await apiClient.RacesAsync()).Select(Map).ToList();
        UserRoles = (await apiClient.RolesAsync()).Select(Map).ToList();
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