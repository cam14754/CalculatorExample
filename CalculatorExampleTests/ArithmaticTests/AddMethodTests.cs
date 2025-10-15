namespace CalculatorExampleTests.ArithmaticTests;

public class AddMethodTests
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-1, -1, -2)]
    [InlineData(0, 0, 0)]
    [InlineData(-1, 1, 0)]
    [InlineData(1.5, 2.5, 4.0)]
    [InlineData(double.MaxValue, 1, double.MaxValue + 1)]

    public void TestAddMethod(double a, double b, double expected)
    {
        //Arange
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        //Act
        var result = calculatorService.Add(a, b);

        //Assert
        Assert.Equal(expected, result);
    }
}
