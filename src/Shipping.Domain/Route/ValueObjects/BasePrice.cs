using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record BasePrice
{
    private BasePrice(string currency, double value)
    {
        Currency = currency;
        Value = value;
    }

    public string Currency { get; }
    public double Value { get; }

    public static DomainResult<BasePrice?> FromRub(double value)
    {
        if (value < 0.0)
        {
            return DomainResult<BasePrice?>.Fail("Price cannot be negative");
        }

        return DomainResult<BasePrice?>.Ok(new BasePrice(currency: "RUB", value: value));
    }
}