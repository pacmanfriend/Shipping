using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record CityName
{
    public string Name { get; }

    private CityName(string name)
    {
        Name = name;
    }

    public static CityName New(string name)
    {
        return new CityName(name);
    }
}