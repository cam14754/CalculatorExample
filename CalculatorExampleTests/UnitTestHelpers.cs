using CalculatorExample.Services;
using CalculatorExample.ViewModel;
using NSubstitute;

namespace CalculatorExampleTests;

public static class UnitTestHelpers
{
    public static (ICalculatorService, IEntryValidateService, MainPageViewModel) CreateViewModel()
    {
        var calculatorService = Substitute.For<ICalculatorService>();
        var entryValidateService = Substitute.For<IEntryValidateService>();
        var viewModel = new MainPageViewModel(calculatorService, entryValidateService);
        return (calculatorService, entryValidateService, viewModel);
    }
}
