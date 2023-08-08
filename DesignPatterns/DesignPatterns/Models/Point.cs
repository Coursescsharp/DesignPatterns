using DesignPatterns.Enums;

namespace DesignPatterns.Models;

public class Point
{
    public double X { get; set; }
    public double Y { get; set; }

    /// <summary>
    /// Initializes a point from either cartesian or polar.
    /// </summary>
    /// <param name="a">x if cartesian, rho if polar</param>
    /// <param name="b">y if cartesian, theta if polar</param>
    /// <param name="system">Coordiante system to use</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public Point(double a,
                 double b,
                 CoordinateSystem system = CoordinateSystem.Cartesian)
    {
        switch (system)
        {
            case CoordinateSystem.Cartesian:
                X = a;
                Y = b;
                break;
            case CoordinateSystem.Polar:
                X = a * Math.Cos(b);
                Y = a * Math.Sin(b);
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(system), system, null);
        }
    }
}
