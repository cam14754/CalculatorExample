// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

namespace CalculatorExample.Services;

public interface ICalculatorService
{
    abstract double Add(double a, double b);
    abstract double Subtract(double a, double b);
    abstract double Multiply(double a, double b);
    abstract double Divide(double a, double b);
    abstract double Power(double a, double b);
    abstract double Root(double a, double b);
}
