namespace ruuf.Area;

public class Square : IArea, ISquare
{
    public int Width { get; set; } 
    public int Height { get; set; } 

    private Square(int side)
    {
        Width = side;
        Height = side;
    }
    public int GetArea() => Width * Height;

    public static IArea Create(int side)
    {
        if(side <= 0) throw new Exception("The side size can't be zero or negative");

        return new Square(side);
    }
}

public interface ISquare
{
    static abstract IArea Create(int side);
}
