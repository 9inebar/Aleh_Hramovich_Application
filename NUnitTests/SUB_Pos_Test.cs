using CSharpCalculator;

namespace NUnitTests;

public class SUB_Pos_Test
{
    double x;
    double y;
    double expected;
    
    [SetUp]
    public void Setup()
    {
        x = 7;
        y = 2;
        expected = 5;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Sub(x, y);
        Assert.That(actual,Is.EqualTo(expected));
    }
}