using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record Price
{
    public string Currency { get; }
    public double Value { get; }

    private Price(string currency, double value)
    {
        Currency = currency;
        Value = value;
    }

    public static Price FromRub(double value)
    {
        return new Price(currency: "RUB", value: value);
    }
}