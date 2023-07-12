// See https://aka.ms/new-console-template for more information

using Factory_Method;

Console.WriteLine("Enter vehicle type...");
try
{
    IDeveloper myDeveloper = GetDeveloperByName(Console.ReadLine()!);
    IVehicle vehicle = myDeveloper.Create();
    vehicle.Move();
}
catch (VehicleTypeException e)
{
    Console.WriteLine(e.Message);
    throw;
}


static IDeveloper GetDeveloperByName(string developerName)
{
    IDeveloper developer;
    switch (developerName)
    {
        case "Unicycle":
            developer = new UnicycleDeveloper();
            break;
        case "Motorcycle":
            developer = new MotorcycleDeveloper();
            break;
        case "Car":
            developer = new CarDeveloper();
            break;
        case "Truck":
            developer = new TruckDeveloper();
            break;
        default:
            throw new VehicleTypeException("Such vehicle type doesn't exist");
    }

    return developer;
}