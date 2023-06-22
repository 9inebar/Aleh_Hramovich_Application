namespace CSharpOOP4;

public class Ball : Shape
{
    private int _radius;

    public int Radius
    {
        get { return _radius; }
    }
    public Ball(string _name, int _radius) : base(_name)
    {
        this._radius = _radius;
        
    }

    public override double calculateVolume()
    {
       return 4 / 3 * Math.PI * (_radius ^ 3);
    }

    public override void PrintShapeInfo()
    {
        Console.WriteLine($"Ball's volume is {calculateVolume()} according to the radius={Radius}");
    }
}