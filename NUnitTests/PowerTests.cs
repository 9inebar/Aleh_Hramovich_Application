using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<<< HEAD:NUnitTests/PowTest.cs
public class PowTest
========
public class PowerTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/PowerTests.cs
{
    int x;
    double y;
    double expected;
    private Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = 7;
        y = 3;
        expected = 343;
    }

    [Test]
    public void DoubleToIntegerPower()
    {
        double actual = myCalc.Pow(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}