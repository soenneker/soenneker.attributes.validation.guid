[![](https://img.shields.io/nuget/v/soenneker.attributes.validation.guid.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.validation.guid/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.validation.guid/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.validation.guid.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid/)

# Soenneker.Attributes.Validation.Guid

A DataAnnotations validator for a required string containing a non-empty GUID.

## Installation

```bash
dotnet add package Soenneker.Attributes.Validation.Guid
```

## Usage

```csharp
using Soenneker.Attributes.Validation.Guid;

public sealed class GetCustomerRequest
{
    [GuidValidation]
    public string? CustomerId { get; init; }
}
```

It works with standard DataAnnotations validation, including ASP.NET Core model validation:

```csharp
using System.ComponentModel.DataAnnotations;

var request = new GetCustomerRequest { CustomerId = input };
var results = new List<ValidationResult>();

bool valid = Validator.TryValidateObject(
    request,
    new ValidationContext(request),
    results,
    validateAllProperties: true);
```

## Validation rules

| Value | Result |
| --- | --- |
| A parseable, non-empty GUID string | Valid |
| `null` | Invalid |
| Malformed or blank string | Invalid |
| `00000000-0000-0000-0000-000000000000` | Invalid |
| A non-string value | Invalid |

Use `Soenneker.Attributes.Validation.Guid.Nullable` when `null` should be accepted. This validator checks GUID syntax and rejects the empty GUID; it does not verify that the identifier exists in a database.
