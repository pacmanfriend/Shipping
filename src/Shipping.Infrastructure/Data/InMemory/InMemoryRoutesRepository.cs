using Shipping.Domain.Common.ValueObjects;
using Shipping.Domain.Route;

namespace Shipping.Infrastructure.Data.InMemory;

public class InMemoryRoutesRepository : IRoutesRepository
{
    private readonly List<Route> _routes =
    [
        new Route.Builder()
            .WithNewId()
            .WithTitle("Москва → Санкт-Петербург")
            .WithDestination("Москва", "Санкт-Петербург")
            .WithDistance(700, "KM")
            .WithEstimatedTime("9:50")
            .WithPrice(30000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithNewId()
            .WithTitle("Екатеринбург → Челябинск")
            .WithDestination("Екатеринбург", "Челябинск")
            .WithDistance(200, "KM")
            .WithEstimatedTime("3:00")
            .WithPrice(15000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithNewId()
            .WithTitle("Казань → Нижний Новгород")
            .WithDestination("Казань", "Нижний Новгород")
            .WithDistance(400, "KM")
            .WithEstimatedTime("6:00")
            .WithPrice(18000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithNewId()
            .WithTitle("Сочи → Краснодар")
            .WithDestination("Сочи", "Краснодар")
            .WithDistance(300, "KM")
            .WithEstimatedTime("4:50")
            .WithPrice(12000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithNewId()
            .WithTitle("Новосибирск → Томск")
            .WithDestination("Новосибирск", "Томск")
            .WithDistance(270, "KM")
            .WithEstimatedTime("4:00")
            .WithPrice(20000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithNewId()
            .WithTitle("Ростов-на-Дону → Волгоград")
            .WithDestination("Ростов-на-Дону", "Волгоград")
            .WithDistance(470, "KM")
            .WithEstimatedTime("6:00")
            .WithPrice(35000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithNewId()
            .WithTitle("Калининград → Гданьск (Польша)")
            .WithDestination("Калининград", "Гданьск")
            .WithDistance(150, "KM")
            .WithEstimatedTime("2:30")
            .WithPrice(50000.0, "RUB")
            .Build(),
        new Route.Builder()
            .WithNewId()
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