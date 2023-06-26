using System.Globalization;

namespace CSharpOOP;

public class ShoppingItem
{
    public string name;
    public int count;
    public double price;
    public double discount;
    public ShoppingItem(string name, string count, string price, string discount)
    {
        //parsing
        this.name = name;
        if (!count.Equals(""))
        {
            this.count = Int32.Parse(count);
        }
        this.price = double.Parse(price, CultureInfo.InvariantCulture);
        this.discount = double.Parse(discount, CultureInfo.InvariantCulture);
    }
}