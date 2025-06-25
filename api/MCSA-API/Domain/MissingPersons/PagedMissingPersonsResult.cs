namespace MCSA_API.Domain.MissingPersons;

public class PagedMissingPersonsResult
{
    public int TotalCount { get; init; }
    public int PageNumber { get; init; }
    public int PageSize { get; init; }
    public List<MissingPerson> MissingPersons { get; init; }
}