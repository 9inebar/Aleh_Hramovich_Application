using CSharpCalculator;

namespace NUnitTests;

public class SqrtTest
{
    double x;
    double y;
    double expected;
    
    [SetUp]
    public void Setup()
    {
        x = 49;
        expected = 7;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Sqrt(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}