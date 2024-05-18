using System.Collections.Immutable;
using ruuf;
using ruuf.Area;
using Xunit;

namespace ruufTest;

public class RectangleTest
{
    
    [Theory]
    [InlineData(-3)]
    [InlineData(-120)]
    [InlineData(-9999)]
    [InlineData(0)]
    public void NegativeOrZero_Width_Should_Throw_ArgumentOutOfRangeException(int width)
    {
        void Action() => Rectangle.Create(width, -3);
        
        Assert.Throws<ArgumentOutOfRangeException>(Action);
    }

    [Theory]
    [InlineData(-3)]
    [InlineData(-120)]
    [InlineData(-9999)]
    [InlineData(0)]
    public void NegativeOrZero_Height_Should_Throw_ArgumentOutOfRangeException(int height)
    {
        void Action() => Rectangle.Create(3, height);
        
        Assert.Throws<ArgumentOutOfRangeException>(Action);
    }
    
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