using CSharpCalculator;

namespace NUnitTests;

public class Pow_Pos_Test
{
    int x;
    double y;
    double expected;
    
    [SetUp]
    public void Setup()
    {
        x = 7;
        y = 3;
        expected = 343;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Pow(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}