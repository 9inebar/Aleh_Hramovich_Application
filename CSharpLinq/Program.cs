// See https://aka.ms/new-console-template for more information
using CSharpOOP2;

#region Task1

using System.Security.Cryptography;

List<int> numbers = new List<int>{1,2,3,4,5,6,7,8,9,10};
IEnumerable<int> numbersDividedByThree = from num in numbers where num % 3 == 0 select num;
foreach (var n in numbersDividedByThree)
{
    Console.WriteLine(n);
}

#endregion

#region Task2

var numbers2 = new List<int>{7,8,-8,9,-9,10,12,13,14,15};
var negativeNumbersBeforeTen = numbers2.Where(n=>n <10);
negativeNumbersBeforeTen.ToList().ForEach(n => Console.WriteLine(n));

#endregion

#region Task3

List<string> collectionOfFive = new List<string> {"Monkey","33.14","a","abc","house that jack built!"};
IEnumerable<string> evenLongItems = from word in collectionOfFive where word.Length % 2 == 0 orderby word select word;
foreach(var w in evenLongItems) 
{
    Console.WriteLine(w);
}

#endregion

#region Task4

var cities = new List<string> { "london", "minsk", "brest", "manchester", "pinsk", "lubliN" };
var citiesStartingAndEndingWithTheSameLetters =
    cities.Where(c => c.ToUpper().StartsWith("L") && c.ToLower().EndsWith("n"));
citiesStartingAndEndingWithTheSameLetters.ToList().ForEach(c=>Console.WriteLine(c));

#endregion

#region Task5

Console.WriteLine("Enter a sentence containing both lower and upper case words:");
var consoleInput = Console.ReadLine();
string[] arrayOfWords = consoleInput.Split(" ");
var arrayOfUpperCaseWords = arrayOfWords.ToList().Where(c =>c.ToCharArray().ToList().All(ch=>Char.IsUpper(ch)));
arrayOfUpperCaseWords.ToList().ForEach(n => Console.WriteLine(n));

#endregion

#region Task6

List<int> listOfTenNumbers = new List<int>{1,2,4,4,2,5,5,6,6,7};
var uniqueNumbers = listOfTenNumbers.Distinct().Reverse();
uniqueNumbers.ToList().ForEach(n =>Console.WriteLine(n));

#endregion

#region Task7

List<int> myNumbers = new List<int>{1,4,7,22,13,19,67,53,77,93};
Console.WriteLine("Enter any number");
var userInput = Console.ReadLine();
myNumbers.Contains(Convert.ToInt32(userInput));
if (myNumbers.Contains(Convert.ToInt32(userInput)))
{
    Console.WriteLine("The collection contains the entered number");
}
else
{
    Console.WriteLine("The collection DOES NOT contain the entered number");
}

#endregion

#region Task8

var collectionOfThreeStrings = new List<string> { "London", "Minsk", "Brest", "Manchester", "Pinsk", "Lublin" };
var sumOfLengthOfAllStrings = 0;
collectionOfThreeStrings.ToList().ForEach(s=>sumOfLengthOfAllStrings += s.Length);
if (sumOfLengthOfAllStrings > 5)
{
    Console.WriteLine(collectionOfThreeStrings.First()+" "+collectionOfThreeStrings.Last());
}

#endregion

#region Task9

var carColors = new List<string> {"red","yellow","green"};

var myCars = carColors.Select(c => new Car(c));
myCars.ToList().ForEach(c=>Console.WriteLine(c));

#endregion

#region Task10

var carColors2 = new List<Car> {new Car("red"),new Car("yellow"),new Car ("green")};

var myColors = carColors2.Select(c =>c.Color);
myColors.ToList().ForEach(c=>Console.WriteLine(c));

#endregion