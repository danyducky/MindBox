namespace MindBox.Geometry.Domain.Entities;

/// <summary>
/// Represents a geometry.
/// </summary>
public abstract class Geometry
{
    /// <summary>
    /// Gets an area of geometry.
    /// </summary>
    /// <returns>Geometry area.</returns>
    public abstract double GetArea();

    /// <summary>
    /// Gets a perimiter of geometry.
    /// </summary>
    /// <returns>Geometry perimiter.</returns>
    public abstract double GetPerimiter();
}
