namespace CSharpOOP4;

public class Pyramid : Shape
{
    private int _height;

    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }

    private int s;

    public int S
    {
        get { return s; }
        set { s = value; }
    }

    public Pyramid(string _name, int _height, int s) : base(_name)
    {
        this._height = _height;
        this.s = s;
    }
    public override double calculateVolume()
    {
        return (1 / 3.0 * s) * _height;
    }
    
    public override void PrintShapeInfo()
    {
        Console.WriteLine($"Pyramid's volume is {calculateVolume()} according to the square={s} and height={_height}");
    }
    
}