using CSharpCalculator;

namespace xUnitTests;

public class IsPositive_Pos_Test
{
    [Fact]
    public void Is7PositiveExpectsTrue()
    {
        double  x = 5;
        bool expected = true;

        Calculator myCalc = new Calculator();
        bool actual = myCalc.isPositive(x);
        Assert.Equal(expected, actual); 
        
    }
}