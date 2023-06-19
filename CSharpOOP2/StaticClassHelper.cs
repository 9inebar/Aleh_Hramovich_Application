using System.Drawing;
using CSharpOOP2;

public static class StaticClassHelper
{
    public static void ReprintCarColor(Car myCar, string color)
    {
        myCar.Color = color;
    }

    public static void ChangeTyres(Car myCar, string tyresBrand)
    {
        myCar.TyresBrand = tyresBrand;
    }
}