namespace Shipping.Domain.Common.ValueObjects;

public record EntityId
{
    private EntityId()
    {
        Value = Guid.NewGuid();
    }

    private EntityId(Guid value)
    {
        Value = value;
    }

    public Guid Value { get; }

    public static Result<EntityId> New()
    {
        return Result<EntityId>.Ok(new EntityId());
    }

    public static Result<EntityId?> FromString(string value)
    {
        if (!Guid.TryParse(value, out Guid guid))
        {
            return Result<EntityId?>.Fail("Invalid entity id");
        }

        return Result<EntityId?>.Ok(new EntityId(value: guid));
    }
}