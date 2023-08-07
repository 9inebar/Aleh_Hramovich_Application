using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<<< HEAD:xUnitTests/SQRTest.cs
public class SQRTest
{
    [Fact]
    public void SquareFromX()
========
public class SquareTests
{
    [Fact]
    public void GetSquareFromNumberPositive()
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/SquareTests.cs
    {
        double x = 36;
        double expected = 6;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sqrt(x);
        Assert.Equal(expected, actual);
    }
}