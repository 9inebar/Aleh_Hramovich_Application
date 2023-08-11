using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class IsPositiveTests
{
    [Fact]
    public void IsNumberPositiveExpectsTrue()
    {
        double  x = 5;
        bool expected = true;

        Calculator myCalc = new Calculator();
        bool actual = myCalc.isPositive(x);
        Assert.Equal(expected, actual); 
        
    }
}