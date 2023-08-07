using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:NUnitTests/SqrtTests.cs
public class SqrtTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:NUnitTests/SqrtTest.cs
public class SqrtTest
========
public class SqrtTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/SqrtTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/SqrtTest.cs
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
        x = 49;
        expected = 7;
    }

    [Test]
    public void GetSquareOutOfNumber()
    {
        double actual = myCalc.Sqrt(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}