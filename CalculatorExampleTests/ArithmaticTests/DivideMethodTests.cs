// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

namespace CalculatorExampleTests.ArithmaticTests;

public class DivideMethodTests
{
    [Theory]
    [InlineData(6, 3, 2)]
    [InlineData(1, 2, 0.5)]
    [InlineData(-10, 2, -5)]
    [InlineData(10, -2, -5)]
    [InlineData(-10, -2, 5)]
    [InlineData(0, 5, 0)]
    [InlineData(double.MaxValue, 1, double.MaxValue)]
    [InlineData(1, double.MaxValue, 1 / double.MaxValue)]
    public void TestDivideMethod(double a, double b, double expected)
    {
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        var result = calculatorService.Divide(a, b);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void Divide_ByZero_Throws()
    {
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        Assert.Throws<DivideByZeroException>(() => calculatorService.Divide(5, 0));
    }
}
