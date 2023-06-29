// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using CSharpCollections1;

/*
#region Task1
//declaring 3 arrays
int[] numbers = {6,9,3,8,7,10,5,4,1,2};
int[] evenNumbers = new int[5];
int[] oddNumbers = new int[5];

int i, j = 0, k = 0;

for (i = 0; i < numbers.Length; i++) {
    if (numbers[i] % 2 == 0) {
        evenNumbers[j] = numbers[i];
        j++;
    } else {
        oddNumbers[k] = numbers[i];
        k++;
    }
}
//sorting even numbers array in asc order
Array.Sort(evenNumbers);
Console.WriteLine("Even numbers are:");
for (i = 0; i < j; i++) {
    Console.WriteLine(evenNumbers[i]);
}

//sorting odd numbers array in asc order
Array.Sort(oddNumbers);
Console.WriteLine("Odd numbers are:");
for (i = 0; i < k; i++) {
    Console.WriteLine(oddNumbers[i]);
}

#endregion

#region Task2

int[] arrayOfNumbers = {4,2,6,9,11,1,25,29,20,3,44,15};
int minArray = arrayOfNumbers.Min();
int maxArray = arrayOfNumbers.Max();
Console.WriteLine(maxArray - minArray);

#endregion

#region Task3

var lastNames = new List<string> {"Smith", "Johns", "Marks", "Murphy", "Connor", "Green","Black"};
lastNames.Sort();
foreach (var i in lastNames)
{
    Console.WriteLine(i);
}

#endregion*/

#region Task 4

List<Citizen> listOfCitizens = new List<Citizen>();
listOfCitizens.Add(new Citizen("Bogdanovich", "Jan", "Jakubovich",new Address("ulica Rakauskaja", "3"),new DateTime(1960,12,15)));
listOfCitizens.Add(new Citizen("Petrovich", "Ivan", "Ivanovich",new Address("ulica Pushkina", "4"),new DateTime(1981,1,5)));
listOfCitizens.Add(new Citizen("Makarevich", "Jan", "Jakubovich",new Address("ulica Krasnaja","2"),new DateTime(1960,12,15)));
listOfCitizens.Add(new Citizen("Ivanovich", "Petr", "Stanislavovich",new Address("ulica Rakauskaja","7"),new DateTime(2010,11,7)));
listOfCitizens.Add(new Citizen("Sharangovich", "Michal", "Tadeushevich",new Address("ulica Rakauskaja","3"),new DateTime(2006,3,22)));

List<Citizen> ListOfCitizensAbleToVote =
    listOfCitizens.Where(citizen => DateTime.UtcNow.Date.CompareTo(citizen.dob) > 18 && citizen.GetAddress==(new Address("ulica Rakauskaja","3"))).ToList();
ListOfCitizensAbleToVote.ForEach(citizen => Console.WriteLine(citizen.ToString()));

#endregion

/*
#region Task5

Dictionary<string, string> myDictionary = new Dictionary<string, string>();
Console.WriteLine("Enter a Contry:Capital");
myDictionary.Add(Console.ReadLine(), Console.ReadLine());
myDictionary.Add(Console.ReadLine(), Console.ReadLine());
myDictionary.Add(Console.ReadLine(), Console.ReadLine());
myDictionary.Add(Console.ReadLine(), Console.ReadLine());
myDictionary.Add(Console.ReadLine(), Console.ReadLine());

Dictionary<string, string> myDictionary2 = new Dictionary<string, string>();
foreach (var keyValuePair in myDictionary)
{
    myDictionary2.Add(keyValuePair.Value, keyValuePair.Key);
}

foreach (var VARIABLE in myDictionary2)
{
    Console.WriteLine($"{VARIABLE.Key} {VARIABLE.Value}");
}
#endregion
*/