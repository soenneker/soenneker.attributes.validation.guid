using System.ComponentModel.DataAnnotations;
using Soenneker.Extensions.String;

namespace Soenneker.Attributes.Validation.Guid;

/// <summary>
/// A validation attribute that ensures a nullable string is a valid, populated GUID. If the value is null, not a GUID, or all zeros GUID, fails validation
/// </summary>
public class GuidValidationAttribute : ValidationAttribute
{
    /// <summary>
    /// Gets error message.
    /// </summary>
    /// <param name="fieldName">The field name.</param>
    /// <returns>The result of the operation.</returns>
    public static string GetErrorMessage(string? fieldName)
    {
        if (fieldName == null)
            return "Field is not valid GUID";

        return $"Field \"{fieldName}\" is not valid GUID";
    }

    protected override ValidationResult? IsValid(object? value, ValidationContext? validationContext)
    {
        if (value == null)
            return new ValidationResult(GetErrorMessage(validationContext?.MemberName));

        if (value is not string s)
            return null;

        if (s.IsValidPopulatedGuid())
            return ValidationResult.Success;

        return new ValidationResult(GetErrorMessage(validationContext?.MemberName));
    }
}