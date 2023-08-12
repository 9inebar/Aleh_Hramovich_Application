using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<<< HEAD:xUnitTests/PowerTest.cs
public class PowerTest
{
    [Fact]
    public void XToYPower()
========
public class PowerTests
{
    [Fact]
    public void NumberToPowerPositive()
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/PowerTests.cs
    {
        int  x = 5;
        double  y = 2;
        double expected = 25;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Pow(x, y);
        Assert.Equal(expected, actual);
    }
}