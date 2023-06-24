namespace CSharpOOP4;

public class Ball : Shape
{
    public Ball(string _name, int _radius) : base(_name)
    {
        this._radius = _radius;
    }
    private int _radius;
    public int Radius
    {
        get { return _radius; }
    }
    //calculating ball's volume
    public override double calculateVolume()
    {
       return 4 / 3 * Math.PI * (Radius ^ 3);
    }
    //printing ball's volume & radius
    public override void PrintShapeInfo()
    {
        Console.WriteLine($"Ball's volume is {calculateVolume()} according to the radius={Radius}");
    }
}