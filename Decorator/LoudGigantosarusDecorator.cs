namespace Decorator;

public class LoudGigantosaurusDecorator : IGigantosaurus //decorator class expands concrete component
{
    private IGigantosaurus igigantosaurus;

    public LoudGigantosaurusDecorator(IGigantosaurus igigantosaurus)
    {
        this.igigantosaurus = igigantosaurus;
    }
    
    public void Roar()
    {
        Console.WriteLine("Loud Rrrrrrr!");
        this.igigantosaurus.Roar();
    }
}