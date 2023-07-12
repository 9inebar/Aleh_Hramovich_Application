namespace Factory_Method;

public class MotorcycleDeveloper : IDeveloper //Motorcycle Developer is a concrete creator in Factory method
{
    public IVehicle Create()
    {
        return new Motorcycle();
    }
}