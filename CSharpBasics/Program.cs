// See https://aka.ms/new-console-template for more information

//new Homework().Task_1();
//new Homework().Task_2();
//new Homework().Task_3();
//new Homework().Task_4();
//new Homework().Task_5();
new Homework().Task_6();

class Homework {
    public void Task_1()
    {
        int num1 = 11;
        double dub = 22.67;
        char letter = 'a';
        bool isBig = false;
        string name = "Aleh";
        Console.WriteLine($"{num1} {dub} {letter} {isBig} {name}");
    }

    public void Task_2()
    {
        Console.WriteLine("Hey, what's your first name?");
        string input1 = Console.ReadLine() ?? "";
        Console.WriteLine("My First Name is " + input1);
        Console.WriteLine("Hey, what's your last name?");
        string input2 = Console.ReadLine()!;
        Console.WriteLine("My Last name is " + input2);
        Console.WriteLine("How old are you?");
        string input3 = Console.ReadLine()!;
        Console.WriteLine("I'm " + input3);
    }

    public void Task_3()
    {
        string words = Console.ReadLine()!;
        string words2 = Console.ReadLine()!;
        string words3 = Console.ReadLine()!;
        string?[] arrayOfStrings = new[] { words, words2, words3 };
        Console.WriteLine(string.Join(",", arrayOfStrings)); // with variable
        Console.WriteLine(string.Join(",",new[] {words, words2, words3})); //inline


        string temp = string.Concat(words , ",",words2, ",",words3);
        Console.WriteLine(temp);
    }

    public void Task_4()
    {
        string subbie = Console.ReadLine();
        string subbie2 = subbie.Substring(2);
        string subbie3 = subbie.Substring(0,3);
        string?[] arrayOfSubbies = { subbie, subbie2, subbie3 };
        Console.WriteLine(string.Join(",", arrayOfSubbies));
    }

    public void Task_5()
    {
        string verse = Console.ReadLine()!; //Not too strong, please and one lump of sugar. I like my tea rather sweet, but my husband prefers his without sugar.
        string opposite = Console.ReadLine()!; //sour
        Console.WriteLine(verse.Replace("sweet", "sour"));
    }

    public void Task_6()
    {
        string low = Console.ReadLine(); //a
        Console.WriteLine(low.ToUpper()); //A

    }
}