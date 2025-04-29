using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record RouteDistance
{
    public double Value { get; init; }
    public string Dimension { get; init; }

    private RouteDistance(double value, string dimension)
    {
        Value = value;
        Dimension = dimension;
    }

    static DomainResult<RouteDistance?> New(double value, string dimension)
    {
        if (value < 0.0)
        {
            return DomainResult<RouteDistance?>.Fail("Distance is less than zero");
        }

        return DomainResult<RouteDistance>.Ok(new RouteDistance(value, dimension))!;
    }

    public static DomainResult<RouteDistance?> FromKilometers(double kilometers)
    {
        return New(kilometers, "Kilometers");
    }
}