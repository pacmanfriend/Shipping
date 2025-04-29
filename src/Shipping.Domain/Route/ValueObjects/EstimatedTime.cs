using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record EstimatedTime
{
    public TimeSpan Value { get; }

    private EstimatedTime(TimeSpan value)
    {
        Value = value;
    }

    public static EstimatedTime New(TimeSpan value)
    {
        return new EstimatedTime(value);
    }
}