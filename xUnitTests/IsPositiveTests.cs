using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:xUnitTests/IsPositiveTests.cs
public class IsPositiveTests
{
    [Fact]
    public void IsNumberPositiveExpectsTrue()
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:xUnitTests/IsPositiveTest.cs
public class IsPositiveTest
{
    [Fact]
    public void IsXPositiveExpectsTrue()
========
public class IsPositiveTests
{
    [Fact]
    public void IsNumberPositiveExpectsTrue()
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/IsPositiveTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):xUnitTests/IsPositiveTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
    {
        double  x = 5;
        bool expected = true;

        Calculator myCalc = new Calculator();
        bool actual = myCalc.isPositive(x);
        Assert.Equal(expected, actual); 
        
    }
}