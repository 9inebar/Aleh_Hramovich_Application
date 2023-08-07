using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:xUnitTests/SquareTests.cs
public class SquareTests
{
    [Fact]
    public void GetSquareFromNumberPositive()
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
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
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):xUnitTests/SQRTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
    {
        double x = 36;
        double expected = 6;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sqrt(x);
        Assert.Equal(expected, actual);
    }
}