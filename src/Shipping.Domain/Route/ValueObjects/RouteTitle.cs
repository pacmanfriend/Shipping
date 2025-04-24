using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record RouteTitle
{
    private RouteTitle(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public static DomainResult<RouteTitle?> New(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return DomainResult<RouteTitle?>.Fail("Route title is empty");
        }

        return DomainResult<RouteTitle?>.Ok(new RouteTitle(value));
    }
}