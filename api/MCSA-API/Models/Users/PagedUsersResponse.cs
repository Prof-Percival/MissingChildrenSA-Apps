namespace MCSA_API.Models.Users;

public sealed class PagedUsersResponse
{
    public int TotalCount { get; init; }
    public int PageNumber { get; init; }
    public int PageSize { get; init; }
    public List<GetUserResponse> Users { get; init; }
}