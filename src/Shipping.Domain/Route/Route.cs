using Shipping.Domain.Common.ValueObjects;
using Shipping.Domain.Route.ValueObjects;

namespace Shipping.Domain.Route;

public class Route
{
    public EntityId Id { get; }
    public RouteTitle Title { get; }
    public CityName From { get; }
    public CityName To { get; }
    public EstimatedTime EstimatedTime { get; }
    public RouteDistance RouteDistance { get; }
    public BasePrice Price { get; }
}