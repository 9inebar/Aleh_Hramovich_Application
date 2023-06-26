namespace CSharpOOP4;

public abstract class Shape
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Shape(string _name)
    {
        this._name = _name;
    }
    public Shape()
    {
        
    }
    //virtual method for shapes' volume calculation
    public virtual void PrintShapeInfo()
    {
        Console.WriteLine($"The shape's name is {Name} and it's volume is {CalculateVolume()}");
    }
//abstract method for printing shapes' values
    public abstract double CalculateVolume();
}