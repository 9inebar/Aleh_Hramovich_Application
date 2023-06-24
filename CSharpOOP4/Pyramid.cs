namespace CSharpOOP4;

public class Pyramid : Shape
{
    public Pyramid(string _name, int _height, int _square) : base(_name)
    {
        this._height = _height;
        this._square = _square;
    }
    private int _height;
    public int Height
    {
        get { return _height; }
    }
    private int _square;
    public int Square
    {
        get { return _square; }
    }
    //calculating the pyramid's volume
    public override double calculateVolume()
    {
        return (1 / 3.0 * Square) * Height;
    }
    //printing the pyramid's volume
    public override void PrintShapeInfo()
    {
        Console.WriteLine($"Pyramid's volume is {calculateVolume()} according to the square={Square} and height={Height}");
    }
}