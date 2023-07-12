namespace Factory_Method;

public class Truck : IVehicle //Concrete product in Factory method
{
    public void Move()
    {
        Console.WriteLine("Truck is moving!");
    }
}