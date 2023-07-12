namespace Factory_Method;

public class CarDeveloper : IDeveloper //Car Developer is a concrete creator in Factory method
{
    public IVehicle Create()
    {
        return new Car();
    }
}