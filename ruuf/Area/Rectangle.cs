
using System.Collections.Immutable;

namespace ruuf.Area;

public class Rectangle : IArea, IRectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
    
    public int GetArea() => Height * Width;

    private Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public static IArea Create(int width, int height)
    {
        if (width <= 0)
            throw new ArgumentOutOfRangeException(nameof(width), "Width must be positive and non-zero.");
    
        if (height <= 0)
            throw new ArgumentOutOfRangeException(nameof(height), "Height must be positive and non-zero.");

        return new Rectangle(width, height);
    }

    public static IArea Create(ImmutableList<Point> points)
    {
        if(points.Count != 4) 
            throw new ArgumentException("The number of points cannot be different than four");

        if (points.Any(e => e.X <= 0 || e.Y <= 0))
        {
            throw new ArgumentOutOfRangeException(nameof(points),"Points values cant be zero or negative");
        }
        
        var equalDistanceMethod = RectangleMethods.EqualDistances(points);
        
        if (!equalDistanceMethod.IsRectangle)
        {
            throw new ArgumentException("The given points do not form a rectangle");
            
        }
        
        return new Rectangle(
            (int)equalDistanceMethod.Values[0], (int)equalDistanceMethod.Values[1]);
    }
    
}

public interface IRectangle
{
    static abstract IArea Create(int width, int height);
    static abstract IArea Create(ImmutableList<Point> points);
}