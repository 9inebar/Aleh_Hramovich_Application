using CSharpCalculator;

namespace xUnitTests;

public class Division_Pos_Test
{
    [Fact]
    public void Divide27By9Expect3()
    {
        double  x = 27;
        double  y = 9;
        double expected = 3;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Divide(x, y);
        Assert.Equal(expected, actual);
    }
}