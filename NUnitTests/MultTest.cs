using CSharpCalculator;

namespace NUnitTests;

public class MultTest
{
    double x;
    double y;
    double expected;
    
    [SetUp]
    public void Setup()
    {
        x = 2;
        y = 2;
        expected = 4;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Multiply(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}