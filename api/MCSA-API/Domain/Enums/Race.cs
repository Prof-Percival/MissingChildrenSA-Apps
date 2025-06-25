using System.ComponentModel;

namespace MCSA_API.Domain;

public enum Race
{
    [Description("African")]
    African = 1,

    [Description("White")]
    White,

    [Description("Indian")]
    Indian,

    [Description("Coloured")]
    Coloured,

    [Description("Asian")]
    Asian,

    [Description("Other")]
    Other,
}