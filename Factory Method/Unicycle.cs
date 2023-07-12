namespace Factory_Method;

public class Unicycle : IVehicle //Concrete product in Factory method
{
    public void Move()
    {
        Console.WriteLine("Unicycle is moving!");
    }
}