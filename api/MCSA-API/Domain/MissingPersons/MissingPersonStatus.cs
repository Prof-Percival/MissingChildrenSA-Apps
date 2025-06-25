using System.ComponentModel;

namespace MCSA_API.Domain.MissingPersons;

public enum MissingPersonStatus
{
    [Description("Not Found")]
    NotFound = 1,

    [Description("Found")]
    Found,

    [Description("Found Deceased")]
    FoundDeceased
}