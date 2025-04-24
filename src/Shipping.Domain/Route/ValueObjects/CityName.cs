using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record CityName
{
    private CityName(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public static Result<CityName?> New(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return Result<CityName?>.Fail("City name is empty");
        }

        return Result<CityName?>.Ok(new CityName(name: name));
    }
}