// See https://aka.ms/new-console-template for more information

var name1 = "Aleh";
Console.WriteLine($"Hello, {name1}!");

int x = 12 * 30; // Statement 1
Console.WriteLine (x); // Statement 2

Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100)); 

int FeetToInches(int feet)
{
    var inches = feet * 12;
    return inches;
}

double alehTest = 22.24;

Console.WriteLine(alehTest);

Console.WriteLine("Enter your name...");
string myName = Console.ReadLine()!;
Console.WriteLine("My name is "+ myName);