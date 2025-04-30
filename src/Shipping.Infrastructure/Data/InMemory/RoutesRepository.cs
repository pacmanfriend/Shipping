using Shipping.Domain.Common.ValueObjects;
using Shipping.Domain.Route;

namespace Shipping.Infrastructure.Data.InMemory;

public class RoutesRepository : IRoutesRepository
{
    private List<Route> Routes { get; set; } =
    [
        new Route.Builder()
            .WithNewId()
            .WithTitle("Быстрый маршрут")
            .WithDestination("Москва", "Санкт-Петербург")
            .WithDistance(1265.5, "KM")
            .WithEstimatedTime(TimeSpan.FromDays(1))
            .WithPrice(5000.0, "RUB")
            .Build()
    ];


    public async Task<List<Route>> GetAllRoutes(CancellationToken cancellationToken = default)
    {
        return Routes;
    }

    public async Task<EntityId> CreateRoute(Route route, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task<Route> UpdateRoute(Route route, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteRoute(EntityId routeId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}