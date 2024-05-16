using System.Collections.Immutable;
using ruuf;
using ruuf.Area;
using Xunit;

namespace ruufTest;

public class RectangleTest
{
    [Fact]
    public void IsRectangleByDistance()
    {
        var firstRectangle = new List<Point>
        {
            new(2, 1),
            new(3, 1),
            new(2, 3),
            new(3, 3)
        };
        
        var wrongRectangle = new List<Point>
        {
            new(2, 1),
            new(3, 1),
            new(2, 3),
            new(3, 4)
        };
        
        var result = RectangleMethods.EqualDistances(firstRectangle.ToImmutableList());
        var anotherResult = RectangleMethods.EqualDistances(wrongRectangle.ToImmutableList());
        
        Assert.True(result.IsRectangle);
        Assert.False(anotherResult.IsRectangle);
    }
}