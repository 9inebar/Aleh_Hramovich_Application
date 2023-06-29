using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualBasic;

namespace CSharpCollections1;

public class Citizen
{
    private string _lastName;
    private string _firstName;
    private string _patronymicName;
    private Address _address;
    public Address GetAddress { get; }
    private DateTime _dob;
    public DateTime dob { get; set; }
    
    
    public Citizen(string lastName, string firstName, string patronymicName, Address address, DateTime dob)
    {
        _lastName = lastName;
        _firstName = firstName;
        _patronymicName = patronymicName;
        _address = address;
        _dob = dob;

    }

    public override string ToString()
    {
        return
            "last name" + _lastName+"first name" +_firstName + "patronymicName" +_patronymicName + " "+_address.ToString()+ "dob"+_dob;
    }
}