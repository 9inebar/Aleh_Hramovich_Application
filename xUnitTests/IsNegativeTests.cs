using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:xUnitTests/IsNegativeTests.cs
public class IsNegativeTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:xUnitTests/IsNegativeTest.cs
public class IsNegativeTest
========
public class IsNegativeTests
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/IsNegativeTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):xUnitTests/IsNegativeTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
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