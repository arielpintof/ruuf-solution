using System.Collections.Immutable;
using ruuf.Area;

namespace ruuf;

public static class Utils
{
    public static double DistanceBetweenTwoPoints(Point first, Point second)
    {
        var firstSquare = Math.Pow(second.X - first.X, 2);
        var secondSquare = Math.Pow(second.Y - first.Y, 2);
        
        return Math.Sqrt(firstSquare + secondSquare);
    }
    
}


