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
    //calculating ball's volume
    public override double CalculateVolume()
    {
       return 4 / 3.0 * Math.PI * (Radius ^ 3);
    }
    //printing ball's volume & radius
    public override void PrintShapeInfo()
    {
        Console.WriteLine($"Ball's volume is {CalculateVolume()} according to the radius={Radius}");
    }
}