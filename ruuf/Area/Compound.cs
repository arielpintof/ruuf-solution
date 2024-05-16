using System.Collections.Immutable;

namespace ruuf.Area;

public class Compound : ICompound
{
    public int Width { get; }
    public int Height { get; }

    private IArea Intersection { get; set; }

    private Compound(IArea shape, IArea intersection)
    {
        Width = shape.Width;
        Height = shape.Height;
        Intersection = intersection;
    }
    public int GetArea()
    {
        return 2 * (Height * Width) - (Intersection.Height * Intersection.Width);
    }

    public static IArea Create(IArea shape, ImmutableList<Point> intersection)
    {
        return new Compound(shape, Rectangle.Create(intersection));
    }
    
}

public interface ICompound : IArea
{
    static abstract IArea Create(IArea shape, ImmutableList<Point> intersection);
}