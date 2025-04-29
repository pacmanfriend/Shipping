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

    public static RouteDistance FromKilometers(double kilometers)
    {
        return new RouteDistance(kilometers, "Kilometers");
    }
}