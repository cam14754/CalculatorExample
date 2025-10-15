using NSubstitute;

namespace CalculatorExampleTests.ViewModelTests;

public class ViewModelTests
{
    [Fact]
    public void ViewModel_InitalTest()
    {
        //Arange
        (_, _, var viewModel) = UnitTestHelpers.CreateViewModel();

        //Act

        //Assert
        Assert.NotNull(viewModel);
        Assert.Equal("Calculator", viewModel.Title);
        Assert.Null(viewModel.Number1);
        Assert.Null(viewModel.Number2);
        Assert.Equal(0, viewModel.Result);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(-5, 7, 2)]
    [InlineData(1.5, 2.5, 4.0)]
    public void ViewModel_SavesServiceResponse(double number1, double number2, double expected)
    {
        // Arrange
        (var calculatorService, var entryValidateService, var viewModel) = UnitTestHelpers.CreateViewModel();

        // Provide the raw text inputs
        viewModel.Number1 = number1.ToString();
        viewModel.Number2 = number2.ToString();

        // Mock return of the doubles parsed above
        entryValidateService.ValidateNumber(viewModel.Number1).Returns(number1);
        entryValidateService.ValidateNumber(viewModel.Number2).Returns(number2);

        // Mock return for Add for those exact doubles
        calculatorService.Add(number1, number2).Returns(expected);

        // Act
        viewModel.AddCommand.Execute(null);

        // Assert
        Assert.Equal(expected, viewModel.Result);
        calculatorService.Received(1).Add(number1, number2);
        entryValidateService.Received(1).ValidateNumber(viewModel.Number1);
        entryValidateService.Received(1).ValidateNumber(viewModel.Number2);
    }

    [Fact]
    public void ViewModel_ValidationFailure_ResetsState()
    {
        //Arrange
        (var calculatorService, var entryValidateService, var viewModel) = UnitTestHelpers.CreateViewModel();
        viewModel.Number1 = "abc";
        viewModel.Number2 = "5";

        entryValidateService
            .When(x => x.ValidateNumber("abc"))
            .Do(_ => throw new InvalidDataException("Invalid"));

        // Act
        viewModel.AddCommand.Execute(null);

        // Assert (reset path)
        Assert.Equal(string.Empty, viewModel.Number1);
        Assert.Equal(string.Empty, viewModel.Number2);
        Assert.Equal(0, viewModel.Result);
        calculatorService.DidNotReceiveWithAnyArgs().Add(default, default);
    }
}
