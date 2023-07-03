using System.Runtime.InteropServices.JavaScript;
using Microsoft.VisualBasic;

namespace CSharpCollections1;

public class Citizen
{
    private string _lastName;
    private string _firstName;
    private string _patronymicName;
    private Address _address;
    public Address GetAddress
    {
        get { return _address; }
    }
    private DateTime _dob;
    public DateTime DOB
    {
        get { return _dob; }
    }


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
            "Last Name: "+ _lastName + ", First Name: "+ _firstName + ", Patronymic Name: "+ _patronymicName + ", Address: "+ _address + ", dob: "+_dob;
    }

    public Int32 CalculateAge()
    {
        return (int) ((DateTime.Now - _dob).TotalDays/365.242199);
    }
}