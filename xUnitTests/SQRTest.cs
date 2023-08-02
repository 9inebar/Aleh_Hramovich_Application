using CSharpCalculator;

namespace xUnitTests;

public class SQRTest
{
    [Fact]
    public void SquareFromX()
    {
        double x = 36;
        double expected = 6;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sqrt(x);
        Assert.Equal(expected, actual);
    }
}