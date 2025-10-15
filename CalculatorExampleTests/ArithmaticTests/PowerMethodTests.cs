// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

namespace CalculatorExampleTests.ArithmaticTests;

public class PowerMethodTests
{
    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(5, 0, 1)]
    [InlineData(-2, 3, -8)]
    [InlineData(-2, 2, 4)]
    [InlineData(9, 0.5, 3)]
    [InlineData(16, -1, 0.0625)]
    [InlineData(2, -3, 0.125)]
    [InlineData(double.MaxValue, 2, double.PositiveInfinity)] // Overflow -> Infinity
    [InlineData(0, 0, 1)] // Math.Pow(0,0) returns 1 by definition in .NET
    public void TestPowerMethod(double a, double b, double expected)
    {
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        var result = calculatorService.Power(a, b);

        Assert.Equal(expected, result);
    }
}
