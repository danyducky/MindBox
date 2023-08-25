using System.Numerics;
using MindBox.Geometry.Domain.Utils;

namespace MindBox.Geometry.Domain.Entities;

/// <summary>
/// Represents a triangle.
/// </summary>
public class Triangle : Geometry
{
    /// <summary>
    /// Gets first side length.
    /// </summary>
    public double SideA { get; }

    /// <summary>
    /// Gets second side length.
    /// </summary>
    public double SideB { get; }

    /// <summary>
    /// Gets third side length.
    /// </summary>
    public double SideC { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="vertexA">Triangle first vertex.</param>
    /// <param name="vertexB">Triangle second vertex.</param>
    /// <param name="vertexC">Triangle third vertex.</param>
    public Triangle(Vector2 vertexA, Vector2 vertexB, Vector2 vertexC)
    {
        SideA = GeometryUtils.GetSideLength(vertexA, vertexB);
        SideB = GeometryUtils.GetSideLength(vertexB, vertexC);
        SideC = GeometryUtils.GetSideLength(vertexC, vertexA);
    }

    /// <inheritdoc/>
    public override double GetArea()
    {
        var semiPerimeter = GetPerimiter() / 2;
        return Math.Sqrt(semiPerimeter
            * (semiPerimeter - SideA)
            * (semiPerimeter - SideB)
            * (semiPerimeter - SideC));
    }

    /// <inheritdoc/>
    public override double GetPerimiter() => SideA + SideB + SideC;

    /// <summary>
    /// Gets triangle height.
    /// </summary>
    /// <returns>Triangle height.</returns>
    public double GetHeight() => 2 * (GetArea() / GetBase());

    /// <summary>
    /// Gets triangle base.
    /// </summary>
    /// <returns>Triangle base.</returns>
    public double GetBase() => GetPerimiter() - SideA - SideB;

    /// <inheritdoc/>
    public override string ToString() => "Triangle";
}
