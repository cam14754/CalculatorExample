// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

using CalculatorExample.Services;
using CommunityToolkit.Mvvm.Input;

namespace CalculatorExample.ViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    public MainPageViewModel(ICalculatorService calculatorService, IEntryValidateService entryValidateService)
    {
        Title = "Calculator";
        this.calculatorService = calculatorService;
        this.entryValidateService = entryValidateService;
    }

    private readonly ICalculatorService calculatorService;
    private readonly IEntryValidateService entryValidateService;

    [ObservableProperty]
    string? number1;

    [ObservableProperty]
    string? number2;

    private double _number1;
    private double _number2;

    [ObservableProperty]
    double result;

    [RelayCommand]
    void Add()
    {
        _number1 = entryValidateService.ValidateNumber(Number1);
        _number2 = entryValidateService.ValidateNumber(Number2);
        Result = calculatorService.Add(_number1, _number2);
    }

    [RelayCommand]
    void Subtract()
    {
        _number1 = entryValidateService.ValidateNumber(Number1);
        _number2 = entryValidateService.ValidateNumber(Number2);
        Result = calculatorService.Subtract(_number1, _number2);
    }

    [RelayCommand]
    void Multiply()
    {
        _number1 = entryValidateService.ValidateNumber(Number1);
        _number2 = entryValidateService.ValidateNumber(Number2);
        Result = calculatorService.Multiply(_number1, _number2);
    }

    [RelayCommand]
    void Divide()
    {
        _number1 = entryValidateService.ValidateNumber(Number1);
        _number2 = entryValidateService.ValidateNumber(Number2);
        Result = calculatorService.Divide(_number1, _number2);
    }

    [RelayCommand]
    void Power()
    {
        _number1 = entryValidateService.ValidateNumber(Number1);
        _number2 = entryValidateService.ValidateNumber(Number2);
        Result = calculatorService.Power(_number1, _number2);
    }

    [RelayCommand]
    void Root()
    {
        _number1 = entryValidateService.ValidateNumber(Number1);
        _number2 = entryValidateService.ValidateNumber(Number2);
        Result = calculatorService.Root(_number1, _number2);
    }
}
