namespace Calculator.Tests;

public class CalcTests
{
    [Fact]
    public void Add_Works() => Assert.Equal(5, Calc.Add(2, 3));
}