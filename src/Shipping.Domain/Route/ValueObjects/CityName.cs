using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record CityName
{
    private CityName(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public static DomainResult<CityName?> New(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return DomainResult<CityName?>.Fail("City name is empty");
        }

        return DomainResult<CityName?>.Ok(new CityName(name: name));
    }
}