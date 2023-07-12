namespace Factory_Method;

public class UnicycleDeveloper : IDeveloper //Unicycle Developer is a concrete creator in Factory method
{
    public IVehicle Create()
    {
        return new Unicycle();
    }
}