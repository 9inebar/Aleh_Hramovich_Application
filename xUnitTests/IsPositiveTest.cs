using CSharpCalculator;

namespace xUnitTests;

public class IsPositiveTest
{
    [Fact]
    public void IsXPositiveExpectsTrue()
    {
        double  x = 5;
        bool expected = true;

        Calculator myCalc = new Calculator();
        bool actual = myCalc.isPositive(x);
        Assert.Equal(expected, actual); 
        
    }
}