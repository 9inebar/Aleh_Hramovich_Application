using CSharpCalculator;

namespace NUnitTests;

public class Div_Pos_Test
{
    double x;
    double y;
    double expected;
    
    [SetUp]
    public void Setup()
    {
        x = 9;
        y = 3;
        expected = 3;
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Divide(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}