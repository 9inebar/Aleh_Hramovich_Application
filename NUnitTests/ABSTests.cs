using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:NUnitTests/ABSTests.cs
public class ABSTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:NUnitTests/ABSTest.cs
public class ABSTest
========
public class ABSTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/ABSTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/ABSTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
{
    double x;
    double expected;
    Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = -5;
        expected = 5;
    }

    [Test]
    public void CheckAbsoluteValueOfNegativeNumber()
    {
        double actual = myCalc.Abs(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}