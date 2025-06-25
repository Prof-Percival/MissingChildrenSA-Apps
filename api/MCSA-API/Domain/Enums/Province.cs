using System.ComponentModel;

namespace MCSA_API.Domain;

public enum Province
{
    [Description("Eastern Cape")]
    EasternCape = 1,

    [Description("Free State")]
    FreeState,

    [Description("Gauteng")]
    Gauteng,

    [Description("KwaZulu-Natal")]
    KwaZuluNatal,

    [Description("Limpopo")]
    Limpopo,

    [Description("Mpumalanga")]
    Mpumalanga,

    [Description("Northern Cape")]
    NorthernCape,

    [Description("North West")]
    NorthWest,

    [Description("Western Cape")]
    WesternCape,
}