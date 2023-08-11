using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class AdditionTest
{
    [Fact]
    public void Add1XPlusYPositive()
    {
        double  x = 10;
        double  y = 20;
        double expected = 30;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Add(x, y);
        Assert.Equal(expected, actual); 
        
    }
}