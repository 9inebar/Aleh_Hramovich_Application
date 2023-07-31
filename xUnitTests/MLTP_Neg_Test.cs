using CSharpCalculator;

namespace xUnitTests;

public class MLTP_Neg_Test
{
    [Fact]
    public void MultiplyBigXBigEqualsOutOfDouble()
    {
        double x = 100000000000000000;
        double y = 100000000000000000;
        string expected = "Wrong input";

        Calculator myCalc = new Calculator();
        var actual = Assert.Throws<NotFiniteNumberException>(() => myCalc.Multiply(x, y))!;
        Assert.Equal(actual.Message,(expected));
    }
}