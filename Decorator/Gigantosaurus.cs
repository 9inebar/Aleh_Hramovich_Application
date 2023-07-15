namespace Decorator;

public class Gigantosaurus : IGigantosaurus //concrete component
{
    void IGigantosaurus.Roar()
    {
        Console.WriteLine("Rrrrrr!");
    }
}