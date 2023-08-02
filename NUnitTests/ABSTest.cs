using CSharpCalculator;

namespace NUnitTests;

public class ABSTest
{
    double x;
    double expected;
    
    [SetUp]
    public void Setup()
    {
        x = -5;
        expected = 5;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Abs(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}