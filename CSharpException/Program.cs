// See https://aka.ms/new-console-template for more information

using CSharpException;


Console.WriteLine("Please enter side 1 length");
try {
    double side1 = Convert.ToDouble(Console.ReadLine());
    if (side1 == 0)
    {
        throw new TriangleException("Can't be 0");
    }
    Console.WriteLine("Please enter side 2 length");
    double side2 = Convert.ToDouble(Console.ReadLine());
    if (side2 == 0)
    {
        throw new TriangleException("Can't be 0");
    }
    Console.WriteLine("Please enter side 3 length");
    double side3 = Convert.ToDouble(Console.ReadLine());
    if (side3 == 0)
    {
        throw new TriangleException("Can't be 0");
    }

    Triangle myTriangle = new Triangle(side1, side2, side3);
    Console.WriteLine($"The triangle sides are {myTriangle.Side1},{myTriangle.Side2},{myTriangle.Side3}");
}
catch (TriangleException te)
{
    Console.WriteLine(te.Message);
}

