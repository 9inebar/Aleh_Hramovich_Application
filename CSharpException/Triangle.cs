using System.ComponentModel.Design;

namespace CSharpException;

public class Triangle
{
    private double side1;

    private double side2;

    private double side3;

    public double Side1
    {
        get { return side1; }
    }

    public double Side2
    {
        get { return side2; }
    }

    public double Side3
    {
        get { return side3; }
    }

    public Triangle()
    {
    }

    public void CheckTriangleSides(double side1, double side2, double side3)
    {
        if (side1 != 0 || side2 != 0 || side3 != 0)             
        { 
            if (side1 > side2 + side3 || side2 > side3 + side1 || side3 > side1 + side2) 
            {
                throw new TriangleException("Side length can't be bigger than sum of two other sides");
            }
            Console.WriteLine($"The triangle sides are {side1},{side2},{side3}");
        }
        else
        {
            throw new TriangleException("Side length can't be zero");
        }
    }

}