// SPDX-License-Identifier: Proprietary
// © 2025 Cameron Strachan, trading as Cameron's Rock Company. All rights reserved.
// Created by Cameron Strachan.
// For personal and educational use only.

namespace CalculatorExample.Services;

public class EntryValidateService : IEntryValidateService
{
    public double ValidateNumber(string? input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return 0;
        }

        if (Double.IsNaN(double.Parse(input)) || Double.IsInfinity(double.Parse(input)))
        {
            throw new InvalidDataException("Input is not a valid number.");
        }

        if (double.TryParse(input, out double number))
        {
            return number;
        }

        throw new InvalidDataException("Input is not a valid number.");
    }
}
