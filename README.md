[![](https://img.shields.io/nuget/v/soenneker.attributes.validation.guid.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.validation.guid/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.validation.guid/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.validation.guid.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.validation.guid/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.validation.guid/actions/workflows/codeql.yml)

# Soenneker.Attributes.Validation.Guid

A validation attribute that ensures a nullable string is a valid, populated GUID. If the value is null, not a GUID, or all zeros GUID, fails validation.

## Install

```bash
dotnet add package Soenneker.Attributes.Validation.Guid
```

## Quick start

```csharp
using Soenneker.Attributes.Validation.Guid;

public sealed class Request
{
    [GuidValidation]
    public string? Value { get; init; }
}
```

A validation attribute that ensures a nullable string is a valid, populated GUID. If the value is null, not a GUID, or all zeros GUID, fails validation.

## What you get

- `GuidValidationAttribute` — A validation attribute that ensures a nullable string is a valid, populated GUID. If the value is null, not a GUID, or all zeros GUID, fails validation.
