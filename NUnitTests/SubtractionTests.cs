using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

<<<<<<<< HEAD:NUnitTests/SubtractionTests.cs
public class SubtractionTests //subtraction by a char
========
public class Sub_Neg_Test //subtraction by a char
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/SubTest.cs
{
    public class SUB_Neg_Test
    {
        double x;
        char y;
<<<<<<<< HEAD:NUnitTests/SubtractionTests.cs
        string expectedNeg;
        double a;
        double b;
        double expectedPos;
        Calculator myCalc;
========
        string expected;
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/SubTest.cs
    
        [SetUp]
        public void Setup()
        {
            x = 7;
            y = 'a';
<<<<<<<< HEAD:NUnitTests/SubtractionTests.cs
            expectedNeg = "Wrong input";
            a = 7;
            b = 2;
            expectedPos = 5;
========
            expected = "Wrong input";
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/SubTest.cs
        }

        [Test]
        public void SubtractCharFromNumberException()
        {
            var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Sub(x, y))!;
            Assert.That(actual.Message,Is.EqualTo(expectedNeg));
        }
<<<<<<<< HEAD:NUnitTests/SubtractionTests.cs
        
        [Test]
        public void NumberMinusNumberPositive()
        {
            double actual = myCalc.Sub(a, b);
            Assert.That(actual,Is.EqualTo(expectedPos));
        }
========
>>>>>>>> 2e9e889 (unit testing frameworks updates):NUnitTests/SubTest.cs
    }
}