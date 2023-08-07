using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<<< HEAD:NUnitTests/SqrtTest.cs
public class SqrtTest
========
public class SqrtTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/SqrtTests.cs
{
    double x;
    double y;
    double expected;
    private Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = 49;
        expected = 7;
    }

    [Test]
    public void GetSquareOutOfNumber()
    {
        double actual = myCalc.Sqrt(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}