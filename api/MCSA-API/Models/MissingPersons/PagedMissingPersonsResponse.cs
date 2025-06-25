namespace MCSA_API.Models.MissingPersons;

public class PagedMissingPersonsResponse
{
    public int TotalCount { get; init; }
    public int PageNumber { get; init; }
    public int PageSize { get; init; }
    public List<MissingPersonViewModel> MissingPersons { get; init; }
}