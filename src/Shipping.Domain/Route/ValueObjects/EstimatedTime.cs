using Shipping.Domain.Common;

namespace Shipping.Domain.Route.ValueObjects;

public record EstimatedTime
{
    private EstimatedTime(TimeSpan value)
    {
        Value = value;
    }

    public TimeSpan Value { get; }

    public static DomainResult<EstimatedTime?> New(TimeSpan value)
    {
        return DomainResult<EstimatedTime?>.Ok(new EstimatedTime(value: value));
    }
}