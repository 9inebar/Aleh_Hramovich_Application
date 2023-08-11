using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class MultiplyTests
{
    [Fact]
    public void MultiplyBigXBigEqualsOutOfDouble()
    {
        double x = 100000000000000000;
        double y = 100000000000000000;
        string expected = "Wrong input";

        Calculator myCalc = new Calculator();
        var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Multiply(x, y));
        Assert.Equal(actual.Message,(expected));
    }
    
    [Fact]
    public void MultiplyNumberByNumberPositive()
    {
        double x = 4;
        double y = 4;
        double expected = 16;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Multiply(x,y);
        Assert.Equal(expected, actual);
    }
}