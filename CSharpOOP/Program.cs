// See https://aka.ms/new-console-template for more information

using System.Globalization;
using CSharpOOP;

Homework_1 myHomework = new Homework_1();
//myHomework.Task1();
//myHomework.Task2();
myHomework.Task3();

class Homework_1
{
    #region Task1

    public void Task1()
    {
        // Entering values from console
        string[] item = EnterShoppingItem();
        // Parsing
        string name = item[0];
        int count = Int32.Parse(item[1]);
        double price = double.Parse(item[2], CultureInfo.InvariantCulture);
        double discount = double.Parse(item[3], CultureInfo.InvariantCulture);
        // Printing
        PrintShoppingItem(name, price, discount, count);
    }

    string[] EnterShoppingItem()
    {
        Console.WriteLine("Enter item name");
        string itemName = Console.ReadLine()!;
        Console.WriteLine("Enter item count");
        string itemCount = Console.ReadLine()!;
        Console.WriteLine("Enter item's price");
        string itemPrice = Console.ReadLine()!;
        Console.WriteLine("Enter the discount");
        string itemDiscount = Console.ReadLine()!;
        // returning array of string values entered from console
        return new string[] { itemName, itemCount, itemPrice, itemDiscount };
    }

    void PrintShoppingItem(string name, double price, double discount,int count=2)
    {
        double totalPrice = count * price - count * price * (discount / 100);
        Console.WriteLine("{0}   {1}(items)  *  {2} eur  (-{3}% discount)  = {4}", name, count, price, discount,
            totalPrice);
    }

    #endregion

    #region Task2

    public void Task2()
    {
        //create array variable for ShoppingItem class constructor with a max number of 3 elements
        ShoppingItem[] items = new ShoppingItem[3];
        for (int i = 0; i < items.Length; i++)
        {
            //Read 3 items
            string[] item = EnterShoppingItem();
            items[i] = new ShoppingItem(item[0], item[1], item[2], item[3]);
        }

        // print final receipt
        printShopingItemArray(items);
    }

    void printShopingItemArray(ShoppingItem[] items)
    {
        Console.WriteLine("Receipt: ");
        foreach (ShoppingItem item in items)
        {
            //print item
            if (item.count == 0)
            {
                PrintShoppingItem(item.name, item.price, item.discount);
            }
            else
            {
                PrintShoppingItem(item.name, item.price, item.discount,item.count);
            }
            
            
        }
    }

    #endregion

    #region Task3
    public void Task3()
    { 
        Task2();
    }
    #endregion

    #region Task4
    public void calcPerimeter() //triangle perimeter calc method
    {
            Console.WriteLine("Type the geometry shape edge values");
            int size = 0;
            size = Convert.ToInt32(Console.ReadLine())!;
            while (size <= 3)
            {
                Console.WriteLine($"To calculate geometry shape you need to have at least 3 sizes");
                size = Convert.ToInt32(Console.ReadLine())!;
            }

            double[] Edges = new Double[Convert.ToInt32(Console.ReadLine())!];
            for (int i = 0; i < Edges.Length; i++)
            {
                Console.WriteLine($"Enter the edge {i + 1}");
                Edges[i] = Convert.ToDouble(Console.ReadLine());
            }

            double TrianglePerimeter = 0;
            foreach (double Edge in Edges)
            {
                TrianglePerimeter += Edge;
            }

            Console.WriteLine($"Triangle perimeter is going to be {TrianglePerimeter}");

            double calcPerimeter(params double[] sides)
            {
                double result = 0;
                foreach (double side in sides)
                {
                    result += side;
                }

                return result;
            }
        }
    #endregion

    #region Task6
    /*
    Наследование:
    Существует какая-то первая модель автомобиля 80 года выпуска, 
    потом выпускались модернизированные варианты, т.е какие-то элементы 
    от старой модели наследовали новые модели: движок, зеркала остались от старой модели в следующем поколении. 
    Вот это наследование.

    Инкапсуляция:
    Есть водитель, который пользуется автомобилем и ему не обязательно знать, 
    как работает двигатель и коробка передач, т.е реализация от него скрыта.
    
    Абстракция:
    Это когда водитель сконцентрирован на основных свойсвах и методах машины - ехать, тормозить, реже - включать фары или сигналиить
    и абстрагируется от менее существенных свойствах типа уровня масла, заполненности бака или дорожного просвета.
    
    Полиморфизм:
    Это когда ты научился ездить на одной марке машины и вполне себе можешь водить другие, ведь: везде есть руль и педали,
    а газ гарантировано находится справа а тормоз слева (левее тормоза может быть только сцепление).    
      */ 
    #endregion
    }