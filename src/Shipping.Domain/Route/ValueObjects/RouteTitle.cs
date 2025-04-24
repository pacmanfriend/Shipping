namespace Shipping.Domain.Route.ValueObjects;

public class RouteTitle
{
    public RouteTitle(string value)
    {
        Value = value;
    }

    public string Value { get; }
}