using CSharpCalculator;

namespace xUnitTests;

public class MLTP_Pos_Test
{
    [Fact]
    public void Multiply4X4Equals16()
    {
        double x = 4;
        double y = 4;
        double expected = 16;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Multiply(x,y);
        Assert.Equal(expected, actual);
    }
}