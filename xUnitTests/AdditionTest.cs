using CSharpCalculator;

namespace xUnitTests;

public class AddPositiveTest
{
    [Fact]
    public void Add10Plus20Expect30()
    {
        double  x = 10;
        double  y = 20;
        double expected = 30;

        Calculator myCalc = new Calculator();
        double actual = myCalc.Add(x, y);
        Assert.Equal(expected, actual); 
        
    }
}