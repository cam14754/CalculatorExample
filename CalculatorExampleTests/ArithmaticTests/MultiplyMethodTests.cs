// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

namespace CalculatorExampleTests.ArithmaticTests;

public class MultiplyMethodTests
{
    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(2, -3, -6)]
    [InlineData(-2, -3, 6)]
    [InlineData(5, 0, 0)]
    [InlineData(0, 5, 0)]
    [InlineData(1.5, 2, 3)]
    [InlineData(1.25, 0.8, 1.0)]
    [InlineData(double.MaxValue, 1, double.MaxValue)]
    [InlineData(double.MaxValue, 2, double.PositiveInfinity)] // Overflow -> Infinity
    public void TestMultiplyMethod(double a, double b, double expected)
    {
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        var result = calculatorService.Multiply(a, b);

        Assert.Equal(expected, result);
    }
}
