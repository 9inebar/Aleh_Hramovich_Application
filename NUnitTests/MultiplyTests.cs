using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:NUnitTests/MultiplyTests.cs
public class MultiplyTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:NUnitTests/MultTest.cs
public class MultTest
========
public class MultiplyTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/MultiplyTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/MultTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
{
    double x;
    double y;
    double expected;
    private Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = 2;
        y = 2;
        expected = 4;
    }

    [Test]
    public void MultiplyTwoNumbers()
    {
        double actual = myCalc.Multiply(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}