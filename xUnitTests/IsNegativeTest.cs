using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<<< HEAD:xUnitTests/IsNegativeTest.cs
public class IsNegativeTest
========
public class IsNegativeTests
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/IsNegativeTests.cs
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