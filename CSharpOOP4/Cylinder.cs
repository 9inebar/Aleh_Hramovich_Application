using System.Runtime.InteropServices.ComTypes;

namespace CSharpOOP4;

public class Cylinder : Shape
{
    private int _height;

    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }

    private int _radius;

    public int Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    public Cylinder(string _name, int _height, int _radius) : base(_name)
    {
        this._height = _height;
        this._radius = _radius;
    }
    public override double calculateVolume()
    {
        return Math.PI * (_radius ^ 2) * _height;
    }
    
    public override void PrintShapeInfo()
    {
        Console.WriteLine($"Cylinder's volume is {calculateVolume()} according to the radius={_radius} " +
                          $"and height={_height}");
    }
}