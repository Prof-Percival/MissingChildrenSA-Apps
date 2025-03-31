namespace MCSA_API.Domain.Users;

public sealed class PagedUsersResult
{
    public int TotalCount { get; init; }
    public int PageNumber { get; init; }
    public int PageSize { get; init; }
    public List<User> Users { get; init; }
}