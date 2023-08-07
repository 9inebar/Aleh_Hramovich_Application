using CSharpCalculator;
using Xunit;

namespace xUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:xUnitTests/MultiplyTests.cs
public class MultiplyTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:xUnitTests/MLTPTest.cs
public class MLTPTest
========
public class MultiplyTests
>>>>>>>> ef2ec11 (unit testing framework corrections):xUnitTests/MultiplyTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):xUnitTests/MLTPTest.cs
{
    [Fact]
    public void MultiplyBigXBigEqualsOutOfDouble()
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
=======
{
    [Fact]
    public void MultiplyXbyY() //positive
>>>>>>> 2e9e889 (unit testing frameworks updates)
    {
        double x = 4;
        double y = 4;
        double expected = 16;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Multiply(x,y);
        Assert.Equal(expected, actual);
    }
<<<<<<< HEAD
<<<<<<<< HEAD:xUnitTests/MultiplyTests.cs
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
    
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
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):xUnitTests/MLTPTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
}