using CSharpCalculator;

namespace xUnitTests;

public class PowerTest
{
    [Fact]
    public void XToYPower()
    {
        int  x = 5;
        double  y = 2;
        double expected = 25;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Pow(x, y);
        Assert.Equal(expected, actual);
    }
}