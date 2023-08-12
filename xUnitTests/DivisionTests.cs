using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class DivisionTests
{
    [Fact]
    public void Divide5By0ExpectException() //a bug found: the Divide method returns null instead of exception
    {
        double x = 5;
        double y = 0;
        string expected = "Wrong input";

        Calculator myCalc = new Calculator();
        var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Divide(x, y));
        Assert.Equal(expected,actual.Message);
    }
    
    [Fact]
    public void DivideXByYExpectPositive()
    {
        double  x = 27;
        double  y = 9;
        double expected = 3;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Divide(x, y);
        Assert.Equal(expected, actual);
    }
}