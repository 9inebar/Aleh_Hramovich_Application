using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

public class MultiplyTests
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