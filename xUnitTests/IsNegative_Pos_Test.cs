using CSharpCalculator;

namespace xUnitTests;

public class IsNegative_Pos_Test
{
    [Fact]
    public void IsTenNegativeFalseExpectsTrue()
    {
        double x = 10;
        bool expected = false;

        Calculator myCalc = new Calculator();
        bool actual = myCalc.isNegative(x);
        Assert.Equal(expected, actual);

    }
}