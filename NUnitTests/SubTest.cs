using CSharpCalculator;

namespace NUnitTests;

public class SubTest //subtraction by a char
{
    public class SUB_Neg_Test
    {
        double x;
        char y;
        string expected;
        
        double a;
        double b;
        double expectedPos;
    
        [SetUp]
        public void Setup()
        {
            
            x = 7;
            y = 'a';
            expected = "Wrong input";
            
            a = 7;
            b = 2;
            expectedPos = 5;
        }

        [Test]
        public void Test1()
        {
            Calculator myCalc = new Calculator();
            var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Sub(x, y))!;
            Assert.That(actual.Message,Is.EqualTo(expected));
        }
        
        [Test]
        public void Test2()
        {
            Calculator myCalc = new Calculator();
            double actual = myCalc.Sub(a, b);
            Assert.That(actual,Is.EqualTo(expectedPos));
        }
    }
}