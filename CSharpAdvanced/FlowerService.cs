using System.Drawing;

namespace CSharpAdvanced;

public class FlowerService<T>
{
    public void PaintFlowers<T>(T flower, string color) where T: Flower
    {
        flower.Color = color;
        flower.Cost *= 1.15;
    }
}