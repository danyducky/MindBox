using MindBox.Geometry.Domain.Entities;
using MindBox.Geometry.Domain.Utils;
using System.Numerics;

namespace MindBox.Geometry.Tests;

/// <summary>
/// Geometry tests.
/// </summary>
public class GeometryTests
{
    [Fact]
    public void Circle_Radius_IsCorrect()
    {
        var circle = new Circle(radius: 5);

        Assert.Equal(5, circle.Radius);
    }

    [Fact]
    public void Circle_Area_IsCorrect()
    {
        var circle = new Circle(radius: 5);
        var area = circle.GetArea();

        // Exact area.
        Assert.Equal(78.539816339744831, area);

        // Rounded area.
        area = Math.Round(area, 2);
        Assert.Equal(78.54, area);
    }

    [Fact]
    public void Circle_Perimiter_IsCorrect()
    {
        var circle = new Circle(radius: 5);
        var perimiter = circle.GetPerimiter();

        // Exact perimiter.
        Assert.Equal(31.415926535897931, perimiter);

        // Rounded perimiter.
        perimiter = Math.Round(perimiter, 2);
        Assert.Equal(31.42, perimiter);
    }

    [Fact]
    public void Triangle_Sides_Sum_EqualsTo_Perimiter()
    {
        var triangle = new Triangle(
            vertexA: new Vector2(-4, 3),
            vertexB: new Vector2(2, 7),
            vertexC: new Vector2(8, -2));

        var perimiter = triangle.GetPerimiter();
        var sum = triangle.SideA + triangle.SideB + triangle.SideC;

        Assert.Equal(sum, perimiter);
    }

    [Fact]
    public void Triangle_Area_IsCorrect()
    {
        var triangle = new Triangle(
            vertexA: new Vector2(-4, 3),
            vertexB: new Vector2(2, 7),
            vertexC: new Vector2(8, -2));

        var area = triangle.GetArea();

        // Exact area.
        Assert.Equal(38.999999999999993, area);

        // Rounded area.
        area = Math.Round(area, 2);
        Assert.Equal(39, area);
    }

    [Fact]
    public void Triangle_Check_Is_Rectangular()
    {
        var triangle = new Triangle(
            vertexA: new Vector2(-4, 3),
            vertexB: new Vector2(2, 7),
            vertexC: new Vector2(8, -2));

        var isRectangular = GeometryUtils.IsRectangular(triangle);
        Assert.True(isRectangular);
    }

    [Fact]
    public void Triangle_Check_Is_Not_Rectangular()
    {
        var triangle = new Triangle(
            vertexA: new Vector2(-8, 3),
            vertexB: new Vector2(2, 7),
            vertexC: new Vector2(8, -1));

        var isRectangular = GeometryUtils.IsRectangular(triangle);
        Assert.False(isRectangular);
    }
}
