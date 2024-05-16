using ruuf.Area;

namespace ruufTest;
public class AreaTest
{
    [Theory]
    [InlineData(3, 2)]
    [InlineData(5, 2)]
    [InlineData(70, 20)]
    public void AreaOfRectangles(int width, int height)
    {
        var area = Rectangle.Create(width, height).GetArea();

        Assert.True(area == width * height);
    }
    
    [Theory]
    [InlineData(3)]
    [InlineData(5)]
    [InlineData(70)]
    public void AreaOfSquares(int side)
    {
        var area = Square.Create(side).GetArea();

        Assert.True(area == side * side);
    }

    [Theory]
    [InlineData(3, 2)]
    [InlineData(5, 2)]
    [InlineData(70, 20)]
    public void AreaOfIsosceles(int width, int height)
    {
        var area = IsoscelesTriangle.Create(width, height).GetArea();
        
        Assert.True(area == width * height / 2);
    }
}