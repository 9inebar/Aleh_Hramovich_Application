using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:NUnitTests/PowerTests.cs
public class PowerTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:NUnitTests/PowTest.cs
public class PowTest
========
public class PowerTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/PowerTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/PowTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
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