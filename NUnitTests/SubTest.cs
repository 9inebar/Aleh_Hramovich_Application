using CSharpCalculator;

namespace NUnitTests;

public class Sub_Neg_Test //subtraction by a char
{
    public class SUB_Neg_Test
    {
        double x;
        char y;
        string expected;
    
        [SetUp]
        public void Setup()
        {
            x = 7;
            y = 'a';
            expected = "Wrong input";
        }

        [Test]
        public void Test1()
        {
            Calculator myCalc = new Calculator();
            var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Sub(x, y))!;
            Assert.That(actual.Message,Is.EqualTo(expected));
        }
    }
}