// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.
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
