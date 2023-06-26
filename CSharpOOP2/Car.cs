namespace CSharpOOP2;

public class Car
{
    public string color;
    public double fuelLevel;
    public double tankVolume = 80;
    
    //constructor
    public Car(string color, double fuelLevel, double tankVolume)
    {
        this.color = color;
        this.fuelLevel = fuelLevel;
        this.tankVolume = tankVolume;
    }
    //empty constructor
    public Car()
    {
        
    }

    public Car(double fuelLevel, double tankVolume)
    {
        
    }

    public void FuelACar(double litersToAdd)
    {
        double newFuelLevel = fuelLevel + litersToAdd;
        if (newFuelLevel < tankVolume) {
            fuelLevel = newFuelLevel;
            CurrentFuelLevel();
        } else if (newFuelLevel == tankVolume) {
            fuelLevel = newFuelLevel;
            Console.WriteLine("The tank is full");
        } else {
            Console.WriteLine(
                $"Error!. You can't add {litersToAdd} liters because tank volume is limited to {tankVolume}.");
            return;
        }
    }

    public void CurrentFuelLevel()
    {
        Console.WriteLine($"Current fuel level is {fuelLevel}");
    }

    private void Ring()
    {
        Console.WriteLine("beep-beep");
    }

    internal void turnTheLightsOn()
    {
        Console.WriteLine("The lights are on!");
    }
}