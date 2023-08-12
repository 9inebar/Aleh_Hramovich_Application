using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<<< HEAD:NUnitTests/AddTest.cs
public class AddTest
========
public class AddTests
>>>>>>>> ef2ec11 (unit testing framework corrections):NUnitTests/AddTests.cs
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