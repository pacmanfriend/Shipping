using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record RouteDistance
{
    private RouteDistance(double value)
    {
        Value = value;
    }

    public double Value { get; init; }

    public static Result<RouteDistance?> New(double value)
    {
        if (value < 0.0)
        {
            return Result<RouteDistance?>.Fail("Distance is less than zero");
        }

        return Result<RouteDistance>.Ok(new RouteDistance(value))!;
    }
}