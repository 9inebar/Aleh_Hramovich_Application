namespace CSharpOOP4;

public abstract class Shape
{
    public Shape(string _name)
    {
        this._name = _name;
    }
    public Shape()
    {
        
    }
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    //virtual method for shapes' volume calculation
    public virtual void PrintShapeInfo()
    {
        Console.WriteLine($"The shape's name is {Name} and it's volume is {calculateVolume()}");
    }
//abstract method for printing shapes' values
    public abstract double calculateVolume();
}