// See https://aka.ms/new-console-template for more information

new Homework2().Task_7();

/*class Homework {
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
}*/

class Homework2
{
    public void Task_1()
    {
        Console.WriteLine("Enter your first name...");
        string name = Convert.ToString(Console.ReadLine()!);
        Console.WriteLine("My name is " + name);

        Console.WriteLine("Enter your class letter...");
        char classLetter = Convert.ToChar(Console.ReadLine()!);
        Console.WriteLine("I'm studying in class " + classLetter);

        Console.WriteLine("Enter your age...");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("I'm " + age + " years old");

        Console.WriteLine("Enter your last homework grade...");
        decimal d = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("My last grade was " + d);
    }

    public void Task_2()
    {
        Console.WriteLine("Enter your age ..."); //int
        string name = (Console.ReadLine()!);
        Console.WriteLine(Int32.Parse(name));

        Console.WriteLine("Enter your grade ..."); //char
        string grade = (Console.ReadLine()!);
        Console.WriteLine(Char.Parse(grade));
    }

    public void Task_3()
    {
        Console.WriteLine("Enter your age ...");
        string input = Console.ReadLine()!;
        bool isParsingSucess = int.TryParse(input, out int age);
        if (isParsingSucess == true)
        {
            Console.WriteLine("Success");
            Console.WriteLine("Your age is {0}", age);
        }
        else
        {
            Console.WriteLine("Not a number");
        }
    }

    public void Task_4()
    {
        int first = 3;
        int second = first + 3;
        int third = first + second;
        Console.WriteLine("first: " +first + ", second: " +second + ", third: " +third);
    }

    public void Task_5()
    {
        string firstGood = "bread";
        string secondGood = "eggs";
        string thirdGood = "milk";
        string forthGood = "meat";
        string fifthGood = "oil";
        
        int firstGoodCount = 1;
        int secondGoodCount = 2;
        int thirdGoodCount = 3;
        int forthGoodCount = 1;
        int fifthGoodCount = 1;

        double firstGoodPrice = 2.49;
        double secondGoodPrice = 3.49;
        double thirdGoodPrice = 1.59;
        double forthGoodPrice = 7.63;
        double fifthGoodPrice = 6.05;

        double TotalPrice = firstGoodCount * firstGoodPrice + secondGoodCount * secondGoodPrice +
                            thirdGoodCount * thirdGoodPrice + forthGoodCount * forthGoodPrice +
                            fifthGoodCount * fifthGoodPrice;
        double TotalPriceWithDiscount = Double.Round(TotalPrice * 0.15, 2);
        Console.WriteLine("Name   "+"Count  "+"Price  ");
        Console.WriteLine(firstGood +"    "+ firstGoodCount + "    " + firstGoodPrice);
        Console.WriteLine(secondGood +"     "+ secondGoodCount + "    " + secondGoodPrice);
        Console.WriteLine(thirdGood +"     "+ thirdGoodCount + "    " + thirdGoodPrice);
        Console.WriteLine(forthGood +"     "+ forthGoodCount + "    " + forthGoodPrice);
        Console.WriteLine(fifthGood +"      "+ fifthGoodCount + "    " + fifthGoodPrice);
        Console.WriteLine("Total Price: "+TotalPrice + "$");
        Console.WriteLine("Discount: " + TotalPriceWithDiscount + "$");
        
    }

    public void Task_6()
    {
        int a = 2;
        double b = 2.4;
        double c = a++ + b/2;
        // 1) b/2 = 2.4/2 = 1.2
        // 2) a+b/2 = 2+1.2 = 3.2
        // 3) a++ = 3
        
        double d = ++a - b/2;
        // 1) ++a = 1+2 = 4
        // 2) b/2 = 2.4/2 = 1.2
        // 3) ++a - b/2= 4-1.2 = 2.8
        
        Console.WriteLine(c);
        Console.WriteLine(d);
    }

    public void Task_7()
    {
        //true block
        //7.1 a == b
        bool a = true, b = true;
        Console.WriteLine("a == b:{0}", a == b);

    //7.2 a && b == c
        a = true;
        b = true;
        bool c = true;
        Console.WriteLine("a && b == c:{0}", a && b == c);
        b = false;
        Console.WriteLine("a || b != c:{0}", a || b != c);
        Console.WriteLine("a != b:{0}",a != b);
        a = false;
        Console.WriteLine("a <= b:{0}", Convert.ToInt32(a) <= Convert.ToInt32(b));
        //false block
        //7.1   a == b
        a = true;
        b = !a;   // b = false
        Console.WriteLine("a == b:{0}", a == b);
        //7.2   a && b == c
        c = false;
        a = true;
        b = true;
        Console.WriteLine("a && b == c:{0}", a && b == c);
        // 7.3  a || b != c   == false
        a = false;
        b = false;
        c = false;
        //    a || b
        //    true || true  = true
        //    true || false = true
        //    false|| true = true
        //    false|| false = false
        Console.WriteLine("a || b != c:{0}", a || b != c);
        //7.4 a != b
        a = false;
        b = false;
        // false != false => false
        Console.WriteLine("a != b:{0}", a != b);
        //7.5  a <= b
        a = true;
        b = false;
        Console.WriteLine("a <= b:{0}", Convert.ToInt32(a) <= Convert.ToInt32(b));
    }
    public void Task_8(){
        int i = 123;
        object o = (object)i; //explicit boxing
        
        o = 123;
        i = (int)o;  // explicit unboxing
    }

    public void Task_9()
    {
        // неявное преобразование:
        short a = 15;
        int b = 12;
        int с = a;
        
        // явное преобразование
        double d = 2.2;
        int e = 1;
        e = (int)d;

    }
}