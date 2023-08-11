using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class IsNegativeTests
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