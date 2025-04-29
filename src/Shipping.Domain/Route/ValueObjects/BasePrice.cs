using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record Price
{
    private Price(string currency, double value)
    {
        Currency = currency;
        Value = value;
    }

    public string Currency { get; }
    public double Value { get; }

    public static DomainResult<Price?> FromRub(double value)
    {
        if (value < 0.0)
        {
            return DomainResult<Price?>.Fail("Price cannot be negative");
        }

        return DomainResult<Price?>.Ok(new Price(currency: "RUB", value: value));
    }
}