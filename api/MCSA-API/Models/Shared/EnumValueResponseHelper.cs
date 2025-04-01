using MCSA_API.Helpers;

namespace MCSA_API.Models.Shared;

public static class EnumValueResponseHelper
{
    public static List<EnumValueResponse> GetValues<T>() where T : struct, Enum
    {
        return EnumHelper.GetValues<T>().Select(enumValue => new EnumValueResponse
        {
            Id = Convert.ToInt32(enumValue),
            Name = enumValue.ToString(),
            Description = enumValue.GetBestDescription(),
        }).ToList();
    }
}