using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<< HEAD
<<<<<<<< HEAD:NUnitTests/AddTests.cs
public class AddTests
========
=======
>>>>>>> 2e9e889 (unit testing frameworks updates)
<<<<<<<< HEAD:NUnitTests/AddTest.cs
public class AddTest
========
public class AddTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/AddTests.cs
<<<<<<< HEAD
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/AddTest.cs
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
         x = 10;
         y = 20;
         expected = 30;
    }

    [Test]
    public void Test1()
    {
        double actual = myCalc.Add(x, y);
        Assert.That(actual,Is.EqualTo(expected));  
    }
}