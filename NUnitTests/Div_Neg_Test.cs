using CSharpCalculator;
using NUnit.Framework.Constraints;

namespace NUnitTests;

public class Div_Neg_Test //division by zero //bug
{
    double x;
    double y;
    InstanceOfTypeConstraint expected;
    
    [SetUp]
    public void Setup()
    {
        x = 9;
        y = 0;
        expected = Is.InstanceOf<DivideByZeroException>();
    }

    [Test]
    public void Test1()
    {
        Calculator myCalc = new Calculator();
        var actual = Assert.Throws<DivideByZeroException>(() => myCalc.Divide(x, y));
        Assert.That(actual,expected);
    }
    //a bug found: the Divide method returns null instead of exception
}