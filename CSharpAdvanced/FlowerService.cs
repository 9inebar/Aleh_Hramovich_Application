
namespace CSharpAdvanced;

public class FlowerService<T>
{
    public void PaintFlowers<T>(T flower, string color, double cost) where T: Flower
    {
        flower.Color = color;
        flower.Cost *= cost;
    }
}