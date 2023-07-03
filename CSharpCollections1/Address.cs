namespace CSharpCollections1;

public class Address
{
    private string street;

    public string getStreet
    {
        get { return street; }
    }
    
    private string house;

    public string getHouse
    {
        get { return house; }
    }

    public Address(string street, string house)
    {
        this.street = street;
        this.house = house;
    }

    public override string ToString()
    {
        return street +", "+ house;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        // If the passed object is not Customer Type, return False
        if (!(obj is Address))
        {
            return false;
        }
        return (this.street == ((Address)obj).street)
               && (this.house == ((Address)obj).house);
    }
}