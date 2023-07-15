// See https://aka.ms/new-console-template for more information

using CSharpAdvanced;

//first task
List<int> newList = new List<int>{1,2,3,4,5};
Console.WriteLine(GenericMethodClass.GetGenericElement(newList));

//second task
Rose myRose = new Rose();
myRose.Cost = 1.76;
myRose.Name = "Roses";
myRose.Color = "red";

Peony myPeony = new Peony();
myPeony.Cost = 2.24;
myPeony.Name = "Peonies";
myPeony.Color = "pink";

Console.WriteLine("Please enter a number of roses");
int amountOfRoses = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter a number of peonies");
int amountOfPeonies = Convert.ToInt32(Console.ReadLine());

GenericMethodClass.PrintCostOfBouquetCheck(myRose, amountOfRoses);
GenericMethodClass.PrintCostOfBouquetCheck(myPeony, amountOfPeonies);

//third task
FlowerService<Flower> flowerService = new FlowerService<Flower>();
flowerService.PaintFlowers(myRose, "yellow");
flowerService.PaintFlowers(myPeony, "violet");

Console.WriteLine(myRose.Cost + " is the new cost of " + myRose.Color + " "+ myRose.Name);
Console.WriteLine(myPeony.Cost + " is the new cost of " + myPeony.Color + " "+ myPeony.Name);

//printing updated cost
GenericMethodClass.PrintCostOfBouquetCheck(myRose, amountOfRoses);
GenericMethodClass.PrintCostOfBouquetCheck(myPeony, amountOfPeonies);

//fourth task
flowerService.RepaintFlowers(myRose, "black");
Console.WriteLine($"I have reprinted my {myRose.Name} color to {myRose.Color}");

flowerService.RevaluateFlowers(myRose, 22.44);
Console.WriteLine($"I have raised my {myRose.Name} price to {myRose.Cost}");


