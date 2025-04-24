using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record EstimatedTime
{
    private EstimatedTime(TimeSpan value)
    {
        Value = value;
    }

    public TimeSpan Value { get; }

    public static Result<EstimatedTime?> New(TimeSpan value)
    {
        return Result<EstimatedTime?>.Ok(new EstimatedTime(value: value));
    }
}