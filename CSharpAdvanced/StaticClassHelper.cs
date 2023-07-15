namespace CSharpAdvanced;

public static class StaticClassHelper
{
    public static void RepaintFlowers<T>(this FlowerService<T> flowerSerice,  Flower flower, string color)
    {
        flower.Color = color;
    }

    public static void RevaluateFlowers<T>(this FlowerService<T> flowerSerice,  Flower flower, double cost)
    {
        flower.Cost = cost;
    }
}