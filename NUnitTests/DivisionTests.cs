using CSharpCalculator;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace NUnitTests;

public class DivisionTests //division by zero //bug
{
    double x;
    double y;
    InstanceOfTypeConstraint expectedNeg;
    double a;
    double b;
    double expectedPos;
    private Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = 9;
        y = 0;
        expectedNeg = Is.InstanceOf<DivideByZeroException>();
        a = 9;
        b = 3;
        expectedPos = 3;
    }

    [Test]
    public void DivisionByZeroException() //a bug found: the Divide method returns null instead of exception
    {
        var actual = Assert.Throws<DivideByZeroException>(() => myCalc.Divide(x, y));
        Assert.That(actual,expectedNeg);
    }
    
    [Test]
    public void PositiveDivisionTest()
    {
        double actual = myCalc.Divide(a, b);
        Assert.That(actual,Is.EqualTo(expectedPos));  
    }
    
}