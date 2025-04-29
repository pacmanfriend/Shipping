using Shipping.Domain.Common.ValueObjects;

namespace Shipping.Domain.Route;

public interface IRoutesRepository
{
    public Task<List<Route>> GetAllRoutes(CancellationToken cancellationToken = default);
    public Task<EntityId> CreateRoute(Route route, CancellationToken cancellationToken = default);
    public Task<Route> UpdateRoute(Route route, CancellationToken cancellationToken = default);
    public Task DeleteRoute(EntityId routeId, CancellationToken cancellationToken = default);
}