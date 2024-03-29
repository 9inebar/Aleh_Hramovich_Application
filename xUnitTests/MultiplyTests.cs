using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<<< HEAD:xUnitTests/MLTPTest.cs
public class MLTPTest
========
public class MultiplyTests
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/MultiplyTests.cs
{
    [Fact]
    public void MultiplyXbyY() //positive
    {
        double x = 4;
        double y = 4;
        double expected = 16;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Multiply(x,y);
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void MultiplyBigXBigEqualsOutOfDouble() //negative
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