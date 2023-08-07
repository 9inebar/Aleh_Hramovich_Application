using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

public class IsPositiveTests
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