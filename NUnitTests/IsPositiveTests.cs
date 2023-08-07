using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<<< HEAD:NUnitTests/IsPositiveTest.cs
public class IsPositiveTest
========
public class IsPositiveTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/IsPositiveTests.cs
{
    object x;
    bool expected;
    private Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = -5;
        expected = false;
    }

    [Test]
    public void CheckIfNegativeNumberIsFalsePositiveTrue()
    {
        bool actual = myCalc.isPositive(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}