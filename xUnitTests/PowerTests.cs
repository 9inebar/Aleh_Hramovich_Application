using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:xUnitTests/PowerTests.cs
public class PowerTests
{
    [Fact]
    public void NumberToPowerPositive()
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
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
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):xUnitTests/PowerTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
    {
        int  x = 5;
        double  y = 2;
        double expected = 25;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Pow(x, y);
<<<<<<< HEAD
        Assert.Equal(expected, actual); 
        
=======
        Assert.Equal(expected, actual);
>>>>>>> 2e9e889 (unit testing frameworks updates)
    }
}