using Microsoft.Extensions.DependencyInjection;
using Shipping.Domain.Driver;
using Shipping.Domain.Route;
using Shipping.Domain.Transportation;
using Shipping.Domain.Vehicle;
using Shipping.Infrastructure.Data.InMemory;

namespace Shipping.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IRoutesRepository, InMemoryRoutesRepository>();
        services.AddSingleton<IVehiclesRepository, InMemoryVehiclesRepository>();
        services.AddSingleton<IDriversRepository, InMemoryDriversRepository>();
        services.AddSingleton<ITransportationsRepository, InMemoryTransportationsRepository>();

        return services;
    }
}