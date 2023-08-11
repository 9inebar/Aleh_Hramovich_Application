using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class PowerTests
{
    [Fact]
    public void NumberToPowerPositive()
    {
        int  x = 5;
        double  y = 2;
        double expected = 25;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Pow(x, y);
        Assert.Equal(expected, actual); 
        
    }
}