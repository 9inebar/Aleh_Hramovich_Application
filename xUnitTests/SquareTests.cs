using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class SquareTests
{
    [Fact]
    public void GetSquareFromNumberPositive()
    {
        double x = 36;
        double expected = 6;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sqrt(x);
        Assert.Equal(expected, actual);
    }
}