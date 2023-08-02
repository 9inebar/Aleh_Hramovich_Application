namespace CSharpAdvanced;

public class GenericMethodClass
{
    public static T GetFirstElement<T>(List<T> listOfElements)
    {
        return listOfElements.First();
    }

    public static double CalculateCostOfBouquet<T>(T flower, int amount) where T: Flower
    {
        return Math.Round(amount * flower.Cost, 2);
    }
    
    public static void PrintCostOfBouquetCheck<T>(T flower, int amount) where T: Flower
    {
        Console.WriteLine($"The cost of {flower.Name} bouquet of {amount} items of {flower.Color} color equals: {CalculateCostOfBouquet(flower, amount)}");
    }
}