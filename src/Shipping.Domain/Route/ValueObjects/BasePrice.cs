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

    public static Result<BasePrice?> FromRub(double value)
    {
        if (value < 0.0)
        {
            return Result<BasePrice?>.Fail("Price cannot be negative");
        }

        return Result<BasePrice?>.Ok(new BasePrice(currency: "RUB", value: value));
    }
}