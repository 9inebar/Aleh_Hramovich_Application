using CSharpCalculator;
using NUnit.Framework;

namespace NUnitTests;

public class SubtractionTests //subtraction by a char
{
    public class SUB_Neg_Test
    {
        double x;
        char y;
        string expectedNeg;
        double a;
        double b;
        double expectedPos;
        Calculator myCalc;
    
        [SetUp]
        public void Setup()
        {
            x = 7;
            y = 'a';
            expectedNeg = "Wrong input";
            a = 7;
            b = 2;
            expectedPos = 5;
        }

        [Test]
        public void SubtractCharFromNumberException()
        {
            var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Sub(x, y))!;
            Assert.That(actual.Message,Is.EqualTo(expectedNeg));
        }
        
        [Test]
        public void NumberMinusNumberPositive()
        {
            double actual = myCalc.Sub(a, b);
            Assert.That(actual,Is.EqualTo(expectedPos));
        }
    }
}