namespace Factory_Method;

public class Motorcycle : IVehicle //Concrete product in Factory method
{
    public void Move()
    {
        Console.WriteLine("Motorcycle is moving!");
    }
}