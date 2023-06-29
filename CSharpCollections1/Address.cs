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
        return "address" + street +"house"+ house;
    }
}