﻿using MCSA_API.Models.Users;

namespace MCSA_API.Domain.Users;

public interface IUserService
{
    Task<Tuple<string, string, DateTime>> AuthenticateUserAsync(string username, string password);
    Task<Tuple<string, User>> CreateUserAsync(CreateUserRequest request);
    Task<Tuple<string, User>> UpdateUserAsync(int userId, UpdateUserRequest request);
    Task<PagedUsersResult> GetUsersAsync(int pageNumber, int pageSize);
    Task<User> GetUserByUsernameAsync(string username);
    Task<User> GetUserByIdAsync(int userId);
}