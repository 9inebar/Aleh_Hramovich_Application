// See https://aka.ms/new-console-template for more information

int[] numbers = {1,2,3,4,5,6,7,8,9,10};
int[] evenNumbers = new int[5];
int[] oddNumbers = new int[5];
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i; j < evenNumbers.Length; j++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenNumbers[j] = numbers[i];
        }
    }
    for (int j = i; j < oddNumbers.Length; j++)
    {
        if (numbers[i] % 2 != 0)
        {
            oddNumbers[j] = numbers[i];
        }
    }
}

foreach (int i in evenNumbers)
{
    Console.WriteLine(i);
}