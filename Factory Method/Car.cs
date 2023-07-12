namespace Factory_Method;

public class Car : IVehicle //Concrete product in Factory method
{
    public void Move()
    {
        Console.WriteLine("Car is moving!");
    }
}