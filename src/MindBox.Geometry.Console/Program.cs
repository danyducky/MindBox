using MindBox.Geometry.Domain.Entities;
using MindBox.Geometry.Domain.Utils;
using System.Numerics;

var circle = new Circle(radius: 5);
var triangle = new Triangle(
    vertexA: new Vector2(-4, 3),
    vertexB: new Vector2(2, 7),
    vertexC: new Vector2(8, -2));

var geometries = new Geometry[] { circle, triangle };

foreach (var geometry in geometries)
{
    Console.WriteLine("{0}:", geometry);
    Console.WriteLine("\t Area: {0}", geometry.GetArea());
    Console.WriteLine("\t Perimiter: {0}", geometry.GetPerimiter());

    Console.WriteLine(Environment.NewLine);
}

var isTriangleRectangular = GeometryUtils.IsRectangular(triangle);
var message = isTriangleRectangular ? "Triangle is rectangular." : "Triangle isn't rectangular.";
Console.WriteLine(message);