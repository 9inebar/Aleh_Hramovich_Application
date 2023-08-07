using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:NUnitTests/IsPositiveTests.cs
public class IsPositiveTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:NUnitTests/IsPositiveTest.cs
public class IsPositiveTest
========
public class IsPositiveTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/IsPositiveTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/IsPositiveTest.cs
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
{
    object x;
    bool expected;
    private Calculator myCalc;
    
    [SetUp]
    public void Setup()
    {
        x = -5;
        expected = false;
    }

    [Test]
    public void CheckIfNegativeNumberIsFalsePositiveTrue()
    {
        bool actual = myCalc.isPositive(x);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}