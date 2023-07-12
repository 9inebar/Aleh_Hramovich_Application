namespace Factory_Method;

public class TruckDeveloper : IDeveloper //Truck Developer is a concrete creator in Factory method
{
    public IVehicle Create()
    {
        return new Truck();
    }
}