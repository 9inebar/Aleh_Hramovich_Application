using CSharpCalculator;
using Xunit.Sdk;

namespace xUnitTests;

public class DivisionTest
{
    [Fact]
    public void DivideXByY()
    {
        double  x = 27;
        double  y = 9;
        double expected = 3;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Divide(x, y);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void DivideXByZeroExpectException() //a bug found: the Divide method returns null instead of exception
    {
        double x = 5;
        double y = 0;
        string expected = "Wrong input";

        Calculator myCalc = new Calculator();
        var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Divide(x, y));
        Assert.Equal("Wrong input",actual.Message);
    }
}