﻿using MCSA_API.Domain.Users;

namespace MCSA_API.Domain.Security;

public interface IJwtHelper
{
    Tuple<string, string, DateTime> GenerateJwtToken(int userId, UserRole userRole);
}