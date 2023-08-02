using CSharpCalculator;

namespace NUnitTests;

public class IsPositiveTest
{
    object x;
    bool expected;
    
    [SetUp]
    public void Setup()
    {
        x = -5;
        expected = false;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        bool actual = myCalc.isPositive(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}