// See https://aka.ms/new-console-template for more information

using CSharpOOP2;

//first example of the car class
Car myCar = new Car();
myCar.color = "green";
myCar.fuelLevel = 0;
myCar.tankVolume = 80;
Console.WriteLine("Enter the fuel amount");
double FuelLiter = double.Parse(Console.ReadLine()!);
myCar.FuelACar(FuelLiter);
double FuelLiter2 = double.Parse(Console.ReadLine()!);
myCar.FuelACar(FuelLiter2);

//second example of the car class
Car myCar2 = new Car{color = "red", fuelLevel = 10, tankVolume = 100};


//third example of the car class
Car myCar3 = new Car("black",5, 90);
double FuelLiter3 = double.Parse(Console.ReadLine()!);
myCar3.FuelACar(FuelLiter3);
double FuelLiter4 = double.Parse(Console.ReadLine()!);
myCar3.FuelACar(FuelLiter4);

//private car method call fails - it has to be either public or internal

//myCar.Ring(); error line

//internal car method call
myCar.turnTheLightsOn();

//fourth example of the car class
Car myCar4 = new Car();
myCar4.color = "white";
myCar4.tankVolume = 70;
double FuelLiter5 = double.Parse(Console.ReadLine()!);
myCar4.FuelACar(FuelLiter5);
double FuelLiter6 = double.Parse(Console.ReadLine()!);
myCar4.FuelACar(FuelLiter6);
//the method works well because by default public double fuelLevel equals 0;