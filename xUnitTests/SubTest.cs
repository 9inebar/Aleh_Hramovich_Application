using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<<< HEAD:xUnitTests/SubTest.cs
public class SubTest
{
    [Fact]
    public void SubstituteXMinusYEqualsExpected()
========
public class SubtractionTests
{
    [Fact]
    public void DifferenceBetweenTwoNumbers()
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/SubtractionTests.cs
    {
        double  x = 4;
        double y = 1;
        double expected = 3;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sub(x,y);
        Assert.Equal(expected, actual);
    }
}