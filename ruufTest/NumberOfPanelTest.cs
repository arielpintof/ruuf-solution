

using System.Collections.Immutable;
using ruuf;
using ruuf.Area;

namespace ruufTest;


public class NumberOfPanelTest
{
    
    public static IEnumerable<object[]> Data()
    {
        yield return [Rectangle.Create(1, 2), Rectangle.Create(2, 4), 4];
        yield return [Rectangle.Create(1, 2), Rectangle.Create(3, 5), 7];
        yield return [Square.Create(2), Rectangle.Create(1, 10), 0];
        yield return [Rectangle.Create(1, 2), IsoscelesTriangle.Create(2, 4), 2];
        yield return [Rectangle.Create(1, 2), IsoscelesTriangle.Create(3, 5), 3];
        yield return [Rectangle.Create(1, 2), Compound.Create(Square.Create(3), 
            new List<Point> { new(2, 1), new(3, 1), new(2, 3), new(3, 3) }.ToImmutableList()), 8];
    }
    
    [Theory]
    [MemberData(nameof(Data))]
    public void NumberOfPanel(IArea panel, IArea roof, int totalPanels)
    {
        var numberOfPanels = MaxPanels.AreaMethod(panel, roof);
        
        Assert.True(numberOfPanels == totalPanels);
    }
    
    
}


