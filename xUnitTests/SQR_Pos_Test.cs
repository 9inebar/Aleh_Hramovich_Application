using CSharpCalculator;

namespace xUnitTests;

public class SQR_Pos_Test
{
    [Fact]
    public void Square36Expected6()
    {
        double x = 36;
        double expected = 6;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sqrt(x);
        Assert.Equal(expected, actual);
    }
}