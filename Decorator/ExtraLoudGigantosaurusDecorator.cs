namespace Decorator;

public class ExtraLoudGigantosaurusDecorator : IGigantosaurus //decorator class expands concrete component
{
    private IGigantosaurus igigantosaurus;
    public ExtraLoudGigantosaurusDecorator(IGigantosaurus igigantosaurus)
    {
        this.igigantosaurus = igigantosaurus;
    }

    public void Roar()
    {
        Console.WriteLine("Extra loud Rrrrrr!");
        this.igigantosaurus.Roar();
    }
}