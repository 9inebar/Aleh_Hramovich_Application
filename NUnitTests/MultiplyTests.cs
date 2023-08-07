using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<<< HEAD:NUnitTests/MultTest.cs
public class MultTest
========
public class MultiplyTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/MultiplyTests.cs
{
    double x;
    double y;
    double expected;
    private Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = 2;
        y = 2;
        expected = 4;
    }

    [Test]
    public void MultiplyTwoNumbers()
    {
        double actual = myCalc.Multiply(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}