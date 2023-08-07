using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

public class ABSTests
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