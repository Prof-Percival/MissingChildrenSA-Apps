using System.ComponentModel;

namespace MCSA_API.Domain.Users;

public enum UserRole
{
    [Description("Super User")]
    SuperUser = 1,

    [Description("Operational Support")]
    OperationalSupport,

    [Description("Receptionist")]
    Receptionist
}