// See https://aka.ms/new-console-template for more information

using System.Collections.Immutable;
using ruuf;
using ruuf.Area;

var rectanglePanel = Rectangle.Create(1,2);
var rectangleRoof = Rectangle.Create(2, 4);
var points = new List<Point>
{
    new(2, 1),
    new(3, 1),
    new(2, 3),
    new(3, 3)
}.ToImmutableList();

var compoundRoof = Compound.Create(Square.Create(3), points);

Console.WriteLine($"Roof Area: {rectangleRoof.GetArea()}, Panel Area: {rectanglePanel.GetArea()}");
var numberOfPanels = MaxPanels.AreaMethod(rectanglePanel, rectangleRoof); 

Console.WriteLine($"Panels count: {numberOfPanels}");