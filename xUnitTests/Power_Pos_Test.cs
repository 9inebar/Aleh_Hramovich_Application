using CSharpCalculator;

namespace xUnitTests;

public class Power_Pos_Test
{
    [Fact]
    public void FiveToTwoPowerExpect25()
    {
        int  x = 5;
        double  y = 2;
        double expected = 25;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Pow(x, y);
        Assert.Equal(expected, actual); 
        
    }
}