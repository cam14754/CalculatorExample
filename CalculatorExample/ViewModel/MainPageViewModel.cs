// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

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
        try
        {
            _number1 = entryValidateService.ValidateNumber(Number1);
            _number2 = entryValidateService.ValidateNumber(Number2);
            Result = calculatorService.Add(_number1, _number2);
        }
        catch (Exception ex)
        {
            Number1 = string.Empty; Number2 = string.Empty; Result = 0;
            Debug.WriteLine($"Error: {ex.Message}");
        }

    }

    [RelayCommand]
    void Subtract()
    {
        try
        {
            _number1 = entryValidateService.ValidateNumber(Number1);
            _number2 = entryValidateService.ValidateNumber(Number2);
            Result = calculatorService.Subtract(_number1, _number2);
        }
        catch (Exception ex)
        {
            Number1 = string.Empty; Number2 = string.Empty; Result = 0;
            Debug.WriteLine($"Error: {ex.Message}");
        }
    }

    [RelayCommand]
    void Multiply()
    {
        try
        {
            _number1 = entryValidateService.ValidateNumber(Number1);
            _number2 = entryValidateService.ValidateNumber(Number2);
            Result = calculatorService.Multiply(_number1, _number2);
        }
        catch (Exception ex)
        {
            Number1 = string.Empty; Number2 = string.Empty; Result = 0;
            Debug.WriteLine($"Error: {ex.Message}");
        }
    }

    [RelayCommand]
    void Divide()
    {
        try
        {
            _number1 = entryValidateService.ValidateNumber(Number1);
            _number2 = entryValidateService.ValidateNumber(Number2);
            Result = calculatorService.Divide(_number1, _number2);
        }
        catch (Exception ex)
        {
            Number1 = string.Empty; Number2 = string.Empty; Result = 0;
            Debug.WriteLine($"Error: {ex.Message}");
        }
    }

    [RelayCommand]
    void Power()
    {
        try
        {
            _number1 = entryValidateService.ValidateNumber(Number1);
            _number2 = entryValidateService.ValidateNumber(Number2);
            Result = calculatorService.Power(_number1, _number2);
        }
        catch (Exception ex)
        {
            Number1 = string.Empty; Number2 = string.Empty; Result = 0;
            Debug.WriteLine($"Error: {ex.Message}");
        }
    }

    [RelayCommand]
    void Root()
    {
        try
        {
            _number1 = entryValidateService.ValidateNumber(Number1);
            _number2 = entryValidateService.ValidateNumber(Number2);
            Result = calculatorService.Root(_number1, _number2);
        }
        catch (Exception ex)
        {
            Number1 = string.Empty; Number2 = string.Empty; Result = 0;
            Debug.WriteLine($"Error: {ex.Message}");
        }
    }
}
