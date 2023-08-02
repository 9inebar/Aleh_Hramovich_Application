using CSharpCalculator;

namespace xUnitTests;

public class IsNegativeTest
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