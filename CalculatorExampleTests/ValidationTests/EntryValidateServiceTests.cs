// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

namespace CalculatorExampleTests.ValidationTests;

public class EntryValidateServiceTests
{
    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("   ")]
    [InlineData("\t")]
    [InlineData("\r\n")]
    [InlineData(" \t\r\n ")]
    [InlineData(" \u00A0 ")] // Non-breaking space
    public void ValidateNumber_NullOrWhitespace_ReturnsZero(string? input)
    {
        var result = new EntryValidateService().ValidateNumber(input);
        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("0", 0d)]
    [InlineData("42", 42d)]
    [InlineData("-42", -42d)]
    [InlineData("3.14159", 3.14159d)]
    [InlineData(" 123 ", 123d)]
    [InlineData("-123.456", -123.456d)]
    public void ValidateNumber_ValidNumericStrings_ReturnsParsedDouble(string input, double expected)
    {
        var result = new EntryValidateService().ValidateNumber(input);
        Assert.Equal(expected, result);
        result.GetType().Should().Be<double>();
    }

    [Theory]
    [InlineData("NaN")]
    [InlineData("1e309")]
    [InlineData("∞")]

    public void ValidateNumber_SpecialFloatingValues_ThrowsInvalidDataException(string input)
    {
        Assert.Throws<InvalidDataException>(() => new EntryValidateService().ValidateNumber(input));
    }

    [Theory]
    [InlineData("123abc")]
    [InlineData("abc123")]
    [InlineData("12.34.56")]
    [InlineData("!@#$%^&*()")]
    [InlineData("&#8734;")]
    public void ValidateNumber_InvalidNumericStrings_ThrowsInvalidDataException(string input)
    {
        Assert.Throws<FormatException>(() => new EntryValidateService().ValidateNumber(input));
    }
}
