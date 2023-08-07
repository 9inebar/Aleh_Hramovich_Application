using CSharpCalculator;
using Xunit;

namespace xUnitTests;

public class SubtractionTests
{
    [Fact]
    public void DifferenceBetweenTwoNumbers()
    {
        double  x = 4;
        double y = 1;
        double expected = 3;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Sub(x,y);
        Assert.Equal(expected, actual);
    }
}