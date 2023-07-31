using CSharpCalculator;

namespace NUnitTests;

public class Add_Pos_Test
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