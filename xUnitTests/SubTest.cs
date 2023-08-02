using CSharpCalculator;

namespace xUnitTests;

public class SubTest
{
    [Fact]
    public void SubstituteXMinusYEqualsExpected()
    {
        double  x = 4;
        double y = 1;
        double expected = 3;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sub(x,y);
        Assert.Equal(expected, actual);
    }
}