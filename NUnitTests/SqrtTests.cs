using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

public class SqrtTests
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