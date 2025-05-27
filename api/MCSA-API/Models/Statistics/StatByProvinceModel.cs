using MCSA_API.Domain.Statistics;

namespace MCSA_API.Models.Statistics;

public sealed class StatByProvinceModel(
    StatByProvince stat)
{
    public string Province { get; } = stat.Province;
    public int Count { get; } = stat.Count;
}