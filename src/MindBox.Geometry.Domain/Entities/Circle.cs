namespace MindBox.Geometry.Domain.Entities;

/// <summary>
/// Represents a circle.
/// </summary>
public class Circle : Geometry
{
    /// <summary>
    /// Circle radius.
    /// </summary>
    public double Radius { get; }

    /// <summary>
    /// Constructor.
    /// </summary>
    /// <param name="radius">Circle radius.</param>
    public Circle(double radius)
    {
        Radius = radius;
    }

    /// <inheritdoc/>
    public override double GetArea() => Math.PI * Math.Pow(Radius, 2);

    /// <inheritdoc/>
    public override double GetPerimiter() => 2 * Math.PI * Radius;

    /// <inheritdoc/>
    public override string ToString() => "Circle";
}
