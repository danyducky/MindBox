using System.Numerics;
using MindBox.Geometry.Domain.Entities;

namespace MindBox.Geometry.Domain.Utils;

/// <summary>
/// Utils for <see cref="Geometry"/>.
/// </summary>
public static class GeometryUtils
{
    /// <summary>
    /// Calculates the side length.
    /// </summary>
    /// <param name="vertexA">First vertex.</param>
    /// <param name="vertexB">Second vertex.</param>
    /// <returns>Side length.</returns>
    public static double GetSideLength(Vector2 vertexA, Vector2 vertexB)
        => Math.Sqrt(Math.Pow(vertexB.X - vertexA.X, 2) + Math.Pow(vertexB.Y - vertexA.Y, 2));

    /// <summary>
    /// Indicates whether triangle is rectangular.
    /// </summary>
    /// <param name="triangle">Triangle to check.</param>
    /// <returns>True, if triangle is rectangular.</returns>
    public static bool IsRectangular(Triangle triangle)
    {
        var a = Math.Pow(triangle.SideA, 2);
        var b = Math.Pow(triangle.SideB, 2);
        var c = Math.Pow(triangle.SideC, 2);

        return (a + b == c) || (a + c == b) || (c + b == a);
    }
}
