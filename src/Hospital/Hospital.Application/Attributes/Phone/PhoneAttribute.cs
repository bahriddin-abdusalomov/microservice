﻿using System.ComponentModel.DataAnnotations;

namespace Accommodation.Application.Attributes.Phone;

[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
public class PhoneNumberAttribute : ValidationAttribute
{
    public override bool IsValid(object value)
    {
        if (value == null) return false;

        string? phoneNumber = value.ToString();

        if (System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^\+\d{12}$"))
            return true;

        return false;
    }
}
