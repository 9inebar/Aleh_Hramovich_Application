namespace CSharpOOP2;

public class Car
{
    private string _tyresBrand = "Pirelli";

    public string TyresBrand
    {
       internal get => _tyresBrand;
        set => _tyresBrand = value;
    }
    private static string _engineType = "gas";
    public static string EngineType
    {
        get { return _engineType; }
        set { _engineType = value; }
    }

    public string Color { get; set; }
    public double fuelLevel;
    public double tankVolume = 80;
    private double _mileage = 347000; 
    public double Mileage
    {
        get { return _mileage; }
    }
    private double _currentSpeed;
    public double CurrentSpeed
    {
        set { _currentSpeed = value; }
    }
    
    //constructor
    public Car(string color, double fuelLevel, double tankVolume)
    {
        this.Color = color;
        this.fuelLevel = fuelLevel;
        this.tankVolume = tankVolume;
    }
    //second constructor (empty)
    public Car()
    {
        
    }
    //third constructor
    public Car(double fuelLevel, double tankVolume)
    {
        
    }
    
    public Car(string color)
    {
        this.color = color;
    }

    /*public void FuelACar(double litersToAdd)
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
    }*/

    public void CurrentFuelLevel()
    {
        Console.WriteLine($"Current fuel level is {fuelLevel}");
    }

    private void Ring()
    {
        Console.WriteLine("beep-beep");
    }

    internal void TurnTheLightsOn()
    {
        Console.WriteLine("The lights are on!");
    }

    public static void ExhaustSound()
    {
        Console.WriteLine("Erondondon!!!");
    }

    public override string ToString()
    {
        return "color: " + this.color;
    }
}