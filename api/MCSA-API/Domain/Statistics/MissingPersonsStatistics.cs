using MCSA_API.Domain.Moderation.Stats;

namespace MCSA_API.Domain.Statistics;

public class MissingPersonsStatistics
{
    public MissingPersonsStats MissingPersonsStats { get; init; }
    public List<StatByProvince> StatsByProvince { get; init; }
}