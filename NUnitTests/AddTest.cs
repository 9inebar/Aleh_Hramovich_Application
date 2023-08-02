using CSharpCalculator;

namespace NUnitTests;

public class AddTest
{
    double x;
    double y;
    double expected;
    
    [SetUp]
    public void Setup()
    {
         x = 10;
         y = 20;
         expected = 30;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Add(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}