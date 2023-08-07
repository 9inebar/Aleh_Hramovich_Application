using CSharpCalculator;
using Xunit;

namespace xUnitTests;

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
    {
        double  x = 5;
        bool expected = true;

        Calculator myCalc = new Calculator();
        bool actual = myCalc.isPositive(x);
        Assert.Equal(expected, actual); 
        
    }
}