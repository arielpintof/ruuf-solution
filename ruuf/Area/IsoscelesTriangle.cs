namespace ruuf.Area;

public class IsoscelesTriangle : IArea, IIsoscelesTriangle
{
    public int Width { get; set; } 
    public int Height { get; set; } 

    public int GetArea() => (int)(Height * Width * 0.5);

    private IsoscelesTriangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public static IArea Create(int width, int height)
    {
        if(width <= 0 || height <=0) 
            throw new ArgumentException("The side size can't be zero or negative");
        
        return new IsoscelesTriangle(width, height);
    }
}


public interface IIsoscelesTriangle
{
    static abstract IArea Create(int width, int height);
}