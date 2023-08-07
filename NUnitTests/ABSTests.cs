using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<<< HEAD:NUnitTests/ABSTest.cs
public class ABSTest
========
public class ABSTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/ABSTests.cs
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