// See https://aka.ms/new-console-template for more information

using CSharpException;

bool isNumberNull = false;
double side1 = 0;
double side2 = 0;
double side3 = 0;
Triangle myTriangle = new Triangle();
while (!isNumberNull)
{
    Console.WriteLine("Please enter side 1 length");
    side1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Please enter side 2 length");
    side2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Please enter side 3 length");
    side3 = Convert.ToDouble(Console.ReadLine());
    
    try
    {
        myTriangle.CheckTriangleSides(side1, side2, side3);
        isNumberNull = true;
    }
    catch(TriangleException te)
    {
        Console.WriteLine(te.Message);
        continue;
    }

}
