namespace MCSA_API.Models.Users;

public sealed class GetUsersRequest
{
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}