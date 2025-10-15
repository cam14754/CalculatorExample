namespace CalculatorExampleTests.ArithmaticTests;

public class RootMethodTests
{
    [Theory]
    [InlineData(27, 3, 3)]
    [InlineData(16, 2, 4)]
    [InlineData(81, 4, 3)]
    [InlineData(32, 5, 2)]
    [InlineData(7, 1, 7)]
    [InlineData(1, 7, 1)]
    [InlineData(0, 3, 0)]
    public void TestRootMethod(double a, double b, double expected)
    {
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        var result = calculatorService.Root(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Root_DegreeZero_Throws()
    {
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        Assert.Throws<ArgumentException>(() => calculatorService.Root(10, 0));
    }
}