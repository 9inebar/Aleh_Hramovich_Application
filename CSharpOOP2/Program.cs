// See https://aka.ms/new-console-template for more information

using CSharpOOP2;

/*
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
*/

//CSharpOOP3 hometask

//getters & setters
Car myCar5 = new Car();
//working getter
Console.WriteLine($"My car's current mileage is {myCar5.Mileage}"); 

//non working private variable

//Console.WriteLine($"My car's current mileage is {myCar5._mileage}"); 

//working getter
Console.WriteLine(myCar5.CurrentSpeed = 150); 

//non working private variable

//Console.WriteLine(myCar5._currentSpeed = 150); 

//calling static variable
Car.EngineType = "Diesel";
Console.WriteLine($"My car engine is now swapped to {Car.EngineType}");

//calling static method
Car.ExhaustSound();

//calling static class first static method
CarHelper.ReprintCarColor(myCar5,  "white");
Console.WriteLine($"My car's color is now {myCar5.Color}");

// calling second static method
CarHelper.ChangeTyres(myCar5, "Michelin");
Console.WriteLine($"My car tyres are now updated to {myCar5.TyresBrand}");