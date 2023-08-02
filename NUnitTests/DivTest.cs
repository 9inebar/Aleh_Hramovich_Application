using CSharpCalculator;
using NUnit.Framework.Constraints;

namespace NUnitTests;

public class DivTest //division by zero //bug
{
    double x;
    double y;
    InstanceOfTypeConstraint expectedExc;
    
    double a;
    double b;
    double expected;
    
    [SetUp]
    public void Setup()
    {
        x = 9;
        y = 0;
        expectedExc = Is.InstanceOf<DivideByZeroException>();
        
        a = 9;
        b = 3;
        expected = 3;
    }
    
    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        double actual = myCalc.Divide(a, b);
        Assert.That(actual,Is.EqualTo(expected));  
    }

    [Test]
    public void Test2()
    {
        Calculator myCalc = new Calculator();
        var actual = Assert.Throws<DivideByZeroException>(() => myCalc.Divide(x, y));
        Assert.That(actual,expectedExc);
    }
    //a bug found: the Divide method returns null instead of exception
}