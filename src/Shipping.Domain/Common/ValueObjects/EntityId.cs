namespace Shipping.Domain.Common.ValueObjects;

public record EntityId
{
    public Guid Value { get; }

    private EntityId(Guid value)
    {
        Value = value;
    }

    public static EntityId New()
    {
        return new(Guid.NewGuid());
    }

    public static EntityId FromString(string id)
    {
        return new EntityId(Guid.Parse(id));
    }

    public static EntityId FromGuid(Guid id)
    {
        return new EntityId(id);
    }
}