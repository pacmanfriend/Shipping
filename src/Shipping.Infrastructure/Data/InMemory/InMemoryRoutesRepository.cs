using Shipping.Domain.Common.ValueObjects;
using Shipping.Domain.Route;

namespace Shipping.Infrastructure.Data.InMemory;

public class InMemoryRoutesRepository : IRoutesRepository
{
    private readonly List<Route> _routes =
    [
        new Route.Builder()
            .WithExitingId(Guid.Parse("2a9c8d45-b01f-4b7a-9a2c-5e8d6f3a1d01"))
            .WithTitle("Москва → Санкт-Петербург")
            .WithDestination("Москва", "Санкт-Петербург")
            .WithDistance(700, "KM")
            .WithEstimatedTime("9:50")
            .WithPrice(30000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithExitingId(Guid.Parse("7c6d3a1b-2e8f-4d5c-9b7a-0cfd2e1a8d3b"))
            .WithTitle("Екатеринбург → Челябинск")
            .WithDestination("Екатеринбург", "Челябинск")
            .WithDistance(200, "KM")
            .WithEstimatedTime("3:00")
            .WithPrice(15000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithExitingId(Guid.Parse("4f3c8e6d-7a5b-4b3c-8d4e-1a2f9c0d7e5f"))
            .WithTitle("Казань → Нижний Новгород")
            .WithDestination("Казань", "Нижний Новгород")
            .WithDistance(400, "KM")
            .WithEstimatedTime("6:00")
            .WithPrice(18000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithExitingId(Guid.Parse("b1a2c3d4-e5f6-7890-a1a2-a3a4k5a6a7a8"))
            .WithTitle("Сочи → Краснодар")
            .WithDestination("Сочи", "Краснодар")
            .WithDistance(300, "KM")
            .WithEstimatedTime("4:50")
            .WithPrice(12000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithExitingId(Guid.Parse("9d8e7c6b-5a4f-3e2d-1c0b-fdca98765432"))
            .WithTitle("Новосибирск → Томск")
            .WithDestination("Новосибирск", "Томск")
            .WithDistance(270, "KM")
            .WithEstimatedTime("4:00")
            .WithPrice(20000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithExitingId(Guid.Parse("e1f2d3c-4b5a-6d7e-8f9c-0a0b1c2d3e4f5"))
            .WithTitle("Ростов-на-Дону → Волгоград")
            .WithDestination("Ростов-на-Дону", "Волгоград")
            .WithDistance(470, "KM")
            .WithEstimatedTime("6:00")
            .WithPrice(35000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithExitingId(Guid.Parse("a1b2c3d4-d5e6-f7a8-b9c0-d1e2f3a4b5c6"))
            .WithTitle("Калининград → Гданьск (Польша)")
            .WithDestination("Калининград", "Гданьск")
            .WithDistance(150, "KM")
            .WithEstimatedTime("2:30")
            .WithPrice(50000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithExitingId(Guid.Parse("f0e1d2c3-b5a4-7d6e-9f8c-7b2a1c0d9e5f"))
            .WithTitle("Владивосток → Хабаровск")
            .WithDestination("Владивосток", "Хабаровск")
            .WithDistance(750, "KM")
            .WithEstimatedTime("11:00")
            .WithPrice(75000.0, "RUB")
            .Build()
    ];

    public async Task<List<Route>> GetAllRoutes(CancellationToken cancellationToken = default)
    {
        return _routes;
    }

    public async Task<Route> GetRoute(Guid routeId, CancellationToken cancellationToken = default)
    {
        return _routes.SingleOrDefault(x => x.Id.Value == routeId)!;
    }

    public async Task<EntityId> CreateRoute(Route route, CancellationToken cancellationToken = default)
    {
        _routes.Add(route);

        return route.Id;
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