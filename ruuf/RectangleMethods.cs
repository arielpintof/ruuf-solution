using System.Collections.Immutable;
using ruuf.Area;
using static ruuf.Utils;

namespace ruuf;

public static class RectangleMethods
{
    public static (bool IsRectangle, List<double> Values) EqualDistances(ImmutableList<Point> points)
    {
        var ad = DistanceBetweenTwoPoints(points.ElementAt(0), points.ElementAt(3));
        var bc = DistanceBetweenTwoPoints(points.ElementAt(1), points.ElementAt(2));
        var ab = DistanceBetweenTwoPoints(points.ElementAt(0), points.ElementAt(1));
        var cd = DistanceBetweenTwoPoints(points.ElementAt(2), points.ElementAt(3));

        var distances = new List<double>{ ad, bc, ab, cd };
        
        return (distances.Distinct().Count() == 2, distances.Distinct().ToList());
        
    }
    
    //AB y BC son perpendiculares , BC y CD son perpendiculares y CD y AD son perpendiculares
    public static void RightAngles(this ImmutableList<Point> points)
    {
        throw new NotImplementedException("Right Angles method has not yet been implemented");
        
        
    }

    private static double Slope(Point first, Point second)
    {
        return (second.Y - first.Y) / (double)(second.X - first.X);
    }

    
    
}