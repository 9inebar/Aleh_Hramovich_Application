namespace CSharpAdvanced;

public static class FlowerHelper
{
    public static void RepaintFlowers<T>(this T flower, string color) where T: Flower
    {
        flower.Color = color;
    }

    public static void RevaluateFlowers<T>(this T flower, double cost) where T: Flower
    {
        flower.Cost = cost;
    }
}