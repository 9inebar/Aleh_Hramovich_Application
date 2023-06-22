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

    public virtual void PrintShapeInfo()
    {
        Console.WriteLine($"The shape's name is {_name} and it's volume is {calculateVolume()}");
    }

    public abstract double calculateVolume();
}