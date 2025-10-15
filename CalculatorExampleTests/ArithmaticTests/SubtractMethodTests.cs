// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.
namespace CalculatorExampleTests.ArithmaticTests;

public class SubtractMethodTests
{
    [Theory]
    [InlineData(5, 3, 2)]
    [InlineData(3, 5, -2)]
    [InlineData(0, 0, 0)]
    [InlineData(-5, -3, -2)]
    [InlineData(-3, 5, -8)]
    [InlineData(3.5, 1.2, 2.3)]
    [InlineData(-2.5, -2.5, 0)]
    [InlineData(1000000, 1, 999999)]
    [InlineData(1.0000001, 0.0000001, 1)]
    [InlineData(double.MaxValue, 1, double.MaxValue - 1)]
    public void TestSubtractMethod(double a, double b, double expected)
    {
        // Arrange
        var calculatorService = new CalculatorExample.Services.CalculatorService();

        // Act
        var result = calculatorService.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }
}
