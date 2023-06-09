// See https://aka.ms/new-console-template for more information

new Homework().Task_3();

class Homework
{
    public void Task_1()
    {
        int randomInt = int.Parse(Console.ReadLine()!);
        if (randomInt % 2 == 0 && randomInt % 5 == 0)
        {
            Console.WriteLine("tutti-frutti");
        }
        else if (randomInt % 5 == 0)
        {
            Console.WriteLine("frutti");
        }
        else if (randomInt % 2 == 0)
        {
            Console.WriteLine("tutti");
        }
        else
        {
            Console.WriteLine("Pick a proper integer!");
        }
    }

    public void Task_2()
    {
        Console.WriteLine("Enter a first number");
        int input1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Now enter a number bigger than previous you entered");
        int input2 = int.Parse(Console.ReadLine()!);
        if (input1 > input2)
        {
            Console.WriteLine("The second number can't be bigger than the first one");
            return;
        }

        for (int i = input1; i <= input2; i++)
        {
            if (i % 2 == 0 && i % 5 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else
            {
                Console.WriteLine("Number {0}, can’t be divided by 2 or 5", i);
            }
        }
    }

    public void Task_3()
    {
        Console.WriteLine("Enter the first number");
        int input1 = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Now enter the second number");
        int input2 = int.Parse(Console.ReadLine()!);
        
        int biggerVal = Math.Max(input1, input2);
        int smallerVal = Math.Min(input1, input2);
        
        if (smallerVal > biggerVal)
        {
            Console.WriteLine("The second number can't be bigger than the first one");
            return;
        }
        
        for (int i = smallerVal; i <= biggerVal; i++)
        {
            if (i % 2 == 0 && i % 5 == 0)
            {
                Console.WriteLine("tutti-frutti");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("frutti");
            }
            else if (i % 2 == 0)
            {
                Console.WriteLine("tutti");
            }
            else
            {
                Console.WriteLine("Number {0}, can’t be divided by 2 or 5", i);
            }
        }
    }
}