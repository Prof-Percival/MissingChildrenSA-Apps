namespace MCSA_API.Models.Shared;

public sealed class PaginationRequest
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}