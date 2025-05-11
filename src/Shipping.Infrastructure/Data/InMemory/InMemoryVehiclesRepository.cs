using Shipping.Domain.Vehicle;

namespace Shipping.Infrastructure.Data.InMemory;

public class InMemoryVehiclesRepository : IVehiclesRepository
{
    private readonly List<Vehicle> _vehicles =
    [
        new()
        {
            Id = Guid.Parse("a1b2c3d4-e5f6-4a7b-8c9d-0e1f2a3b4c5d"),
            VehicleType = "Тягач",
            LicensePlate = "А123ВС777",
            Payload = 5000,
            BodyVolume = 20.5,
            TechnicalCondition = "Исправен",
            LastServiceDate = new DateTimeOffset(2024, 5, 15, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 25.5
        },
        new()
        {
            Id = Guid.Parse("f47ac10b-58cc-4372-a567-0e02b2c3d4e5"),
            VehicleType = "Тягач",
            LicensePlate = "В456АВ777",
            Payload = 3000,
            BodyVolume = 35.0,
            TechnicalCondition = "Требует ремонта",
            LastServiceDate = new DateTimeOffset(2024, 3, 10, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 30.2
        },
        new()
        {
            Id = Guid.Parse("6ba7b810-9dad-11d1-80b4-00c04fd430c8"),
            VehicleType = "Легковой автомобиль",
            LicensePlate = "С789МН777",
            Payload = 500,
            BodyVolume = 3.2,
            TechnicalCondition = "Исправен",
            LastServiceDate = new DateTimeOffset(2024, 6, 1, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 8.7
        },
        new()
        {
            Id = Guid.Parse("550e8400-e29b-41d4-a716-446655440000"),
            VehicleType = "Тягач",
            LicensePlate = "К012ОР777",
            Payload = 3500,
            BodyVolume = 18.0,
            TechnicalCondition = "На обслуживании",
            LastServiceDate = new DateTimeOffset(2024, 4, 22, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 18.9
        },
        new()
        {
            Id = Guid.Parse("1b9d6bcd-bbfd-4b2d-9b5d-ab8dfbbd4bed"),
            VehicleType = "Тягач",
            LicensePlate = "М345ТЕ777",
            Payload = 8000,
            BodyVolume = 0,
            TechnicalCondition = "Исправен",
            LastServiceDate = new DateTimeOffset(2024, 2, 28, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 32.4
        },
        new()
        {
            Id = Guid.Parse("c9bf9e57-1685-4a9b-87a6-6f4a7b3d8c2e"),
            VehicleType = "Минивэн",
            LicensePlate = "Т678АН777",
            Payload = 1000,
            BodyVolume = 6.5,
            TechnicalCondition = "Исправен",
            LastServiceDate = new DateTimeOffset(2024, 7, 5, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 11.3
        },
        new()
        {
            Id = Guid.Parse("3f2504e0-4f89-11d3-9a0c-0305e82c3301"),
            VehicleType = "Рефрижератор",
            LicensePlate = "Р901СК777",
            Payload = 7000,
            BodyVolume = 12.8,
            TechnicalCondition = "Неисправен",
            LastServiceDate = new DateTimeOffset(2023, 11, 17, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 27.1
        },
        new()
        {
            Id = Guid.Parse("d5a8f8e0-4f3b-11eb-ae93-0242ac130002"),
            VehicleType = "Рефрижератор",
            LicensePlate = "Л234РЕФ777",
            Payload = 4000,
            BodyVolume = 22.4,
            TechnicalCondition = "Исправен",
            LastServiceDate = new DateTimeOffset(2024, 1, 20, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 20.0
        },
        new()
        {
            Id = Guid.Parse("2ab8c430-85f3-11eb-8dcd-0242ac120003"),
            VehicleType = "Погрузчик",
            LicensePlate = "П567ПОГ777",
            Payload = 2000,
            BodyVolume = 0,
            TechnicalCondition = "Исправен",
            LastServiceDate = new DateTimeOffset(2024, 8, 12, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 15.6
        },
        new()
        {
            Id = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
            VehicleType = "Тягач",
            LicensePlate = "Х890ВНЕ777",
            Payload = 700,
            BodyVolume = 4.1,
            TechnicalCondition = "Исправен",
            LastServiceDate = new DateTimeOffset(2024, 9, 1, 0, 0, 0, TimeSpan.Zero),
            FuelConsumption = 12.4
        },
    ];

    public async Task<List<Vehicle>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return _vehicles;
    }

    public Task<Guid> CreateVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken = default)
    {
        vehicle.Id = Guid.NewGuid();

        _vehicles.Add(vehicle);

        return Task.FromResult(vehicle.Id);
    }

    public Task UpdateVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteVehicleAsync(Vehicle vehicle, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}