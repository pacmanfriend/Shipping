using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record RouteTitle
{
    public string Value { get; }

    private RouteTitle(string value)
    {
        Value = value;
    }

    public static RouteTitle New(string value)
    {
        return new RouteTitle(value);
    }
}