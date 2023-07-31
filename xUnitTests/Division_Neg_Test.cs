using CSharpCalculator;
using Xunit.Sdk;

namespace xUnitTests;

public class Division_Neg_Test
{
    [Fact]
    public void Divide5By0ExpectException()
    {
        double x = 5;
        double y = 0;
        string expected = "Wrong input";

        Calculator myCalc = new Calculator();
        var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Divide(x, y));
        Assert.Equal("Wrong input",actual.Message);
    }
    //a bug found: the Divide method returns null instead of exception
}