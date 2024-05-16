using ruuf.Area;

namespace ruuf;

public static class MaxPanels
{
    public static int AreaMethod(IArea panel, IArea roof)
    {
        if (panel.Height > roof.Height) return 0;
        if (panel.Width > roof.Width) return 0;

        var panelArea = panel.GetArea();
        var roofArea = roof.GetArea();

        return roofArea / panelArea;
    }

    public static int AnotherMethod()
    {
        throw new NotImplementedException();
    }
}