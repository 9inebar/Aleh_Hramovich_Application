using CSharpCalculator;

namespace xUnitTests;

public class Sub_Pos_Test
{
    [Fact]
    public void Substitute4Minus1Equals3()
    {
        double  x = 4;
        double y = 1;
        double expected = 3;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sub(x,y);
        Assert.Equal(expected, actual);
    }
}