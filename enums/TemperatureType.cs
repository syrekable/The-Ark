using System.ComponentModel;

namespace The_Ark.enums
{
    public enum TemperatureType
    {
        [Description("<-250*C,-80*C)")]
        Freezing = 0,
        [Description("<-80*C,0*C)")]
        Cold = 1,
        [Description("<-10*C,35*C)")]
        EarthLike = 2,
        [Description("<30*C,60*C)")]
        Hot = 3,
        [Description("<60*C,inf)")]
        Lethal = 4
    }
}