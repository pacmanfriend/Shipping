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

    public static DomainResult<EntityId> New()
    {
        return DomainResult<EntityId>.Ok(new EntityId());
    }

    public static DomainResult<EntityId?> FromString(string value)
    {
        if (!Guid.TryParse(value, out Guid guid))
        {
            return DomainResult<EntityId?>.Fail("Invalid entity id");
        }

        return DomainResult<EntityId?>.Ok(new EntityId(value: guid));
    }
}