using FluentAssertions;
using Soenneker.Tests.Unit;
using Xunit;

namespace Soenneker.Attributes.Validation.Guid.Tests;

public sealed class GuidValidationAttributeTests : UnitTest
{
    [Fact]
    public void Default()
    {

    }

    [Fact]
    public void Valid_guid_should_validate()
    {
        var attribute = new GuidValidationAttribute();

        var value = Faker.Random.Guid().ToString();

        bool result = attribute.IsValid(value);

        result.Should().BeTrue();
    }

    [Fact]
    public void Null_value_should_not_validate()
    {
        var attribute = new GuidValidationAttribute();

        string? value = null;

        bool result = attribute.IsValid(value);

        result.Should().BeFalse();
    }

    [Fact]
    public void Invalid_guid_should_not_validate()
    {
        var attribute = new GuidValidationAttribute();

        string value = Faker.Random.String(5);

        bool result = attribute.IsValid(value);

        result.Should().BeFalse();
    }

    [Fact]
    public void Empty_guid_should_not_validate()
    {
        var attribute = new GuidValidationAttribute();

        var value = System.Guid.Empty.ToString();

        bool result = attribute.IsValid(value);

        result.Should().BeFalse();
    }
}
