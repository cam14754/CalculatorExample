// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

using CommunityToolkit.Mvvm.Input;

namespace CalculatorExample.ViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    public MainPageViewModel()
    {
        Title = "Calculator";
    }

    [ObservableProperty]
    double number1;

    [ObservableProperty]
    double number2;

    [ObservableProperty]
    double result;

    [RelayCommand]
    void Add()
    {
        Result = Number1 + Number2;
    }

    [RelayCommand]
    void Subtract()
    {
        Result = Number1 - Number2;
    }

    [RelayCommand]
    void Multiply()
    {
        Result = Number1 * Number2;
    }

    [RelayCommand]
    void Divide()
    {
        if (Number2 != 0)
        {
            Result = Number1 / Number2;
        }
        else
        {
            // Handle division by zero if necessary
            Result = double.NaN; // or some other value indicating error
        }
    }

    [RelayCommand]
    void Power()
    {
        Result = Math.Pow(Number1, Number2);
    }

    [RelayCommand]
    void Root()
    {
        if (Number2 != 0)
        {
            Result = Math.Pow(Number1, 1.0 / Number2);
        }
        else
        {
            // Handle root of degree zero if necessary
            Result = double.NaN; // or some other value indicating error
        }
    }
}
