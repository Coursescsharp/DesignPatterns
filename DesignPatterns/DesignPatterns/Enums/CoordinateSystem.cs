using System.Runtime.Serialization;

namespace DesignPatterns.Enums;

public enum CoordinateSystem
{
    [EnumMember(Value = "Cartesian")]
    Cartesian = 1,

    [EnumMember(Value = "Polar")]
    Polar = 2
}
