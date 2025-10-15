// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

namespace CalculatorExample.Services;

public class CalculatorService : ICalculatorService
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Divide(double a, double b)
    {
        return b == 0 ? throw new DivideByZeroException() : a / b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Power(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double Root(double a, double b)
    {
        return b == 0 ? throw new ArgumentException("Root degree cannot be zero.") : Math.Pow(a, 1.0 / b);
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }
}
