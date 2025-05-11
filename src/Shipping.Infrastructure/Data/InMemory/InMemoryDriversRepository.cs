using Shipping.Domain.Driver;

namespace Shipping.Infrastructure.Data.InMemory;

public class InMemoryDriversRepository : IDriversRepository
{
    private readonly List<Driver> _drivers =
    [
        new()
        {
            Id = Guid.Parse("e7d8e9f0-a1b2-4c3d-8e5f-6a7b8c9d0e1f"),
            VehicleId = Guid.Parse("a1b2c3d4-e5f6-4a7b-8c9d-0e1f2a3b4c5d"),
            FirstName = "Иван",
            LastName = "Иванов",
            Age = 35,
            Experience = 10,
            Salary = 50000
        },
        new()
        {
            Id = Guid.Parse("2c3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"),
            VehicleId = Guid.Parse("f47ac10b-58cc-4372-a567-0e02b2c3d4e5"),
            FirstName = "Петр",
            LastName = "Петров",
            Age = 42,
            Experience = 18,
            Salary = 60000
        },
        new()
        {
            Id = Guid.Parse("9a8b7c6d-5e4f-3a2b-1c0d-9e8f7a6b5c4d"),
            VehicleId = Guid.Parse("6ba7b810-9dad-11d1-80b4-00c04fd430c8"),
            FirstName = "Сергей",
            LastName = "Смирнов",
            Age = 28,
            Experience = 5,
            Salary = 45000
        },
        new()
        {
            Id = Guid.Parse("0f1e2d3c-4b5a-6978-8f9e-0d1c2b3a4958"),
            VehicleId = Guid.Parse("550e8400-e29b-41d4-a716-446655440000"),
            FirstName = "Алексей",
            LastName = "Соколов",
            Age = 50,
            Experience = 25,
            Salary = 70000
        },
        new()
        {
            Id = Guid.Parse("a0b1c2d3-e4f5-6a7b-8c9d-0e1f2a3b4c5d"),
            VehicleId = Guid.Parse("1b9d6bcd-bbfd-4b2d-9b5d-ab8dfbbd4bed"),
            FirstName = "Дмитрий",
            LastName = "Кузнецов",
            Age = 31,
            Experience = 7,
            Salary = 52000
        },
        new()
        {
            Id = Guid.Parse("b3c4d5e6-f7a8-49b8-8c7d-6a5b4c3d2e1f"),
            VehicleId = Guid.Parse("c9bf9e57-1685-4a9b-87a6-6f4a7b3d8c2e"),
            FirstName = "Николай",
            LastName = "Попов",
            Age = 44,
            Experience = 20,
            Salary = 63000
        },
        new()
        {
            Id = Guid.Parse("4d5c6b7a-89f0-1e2d-3c4b-5a6d7f8e9c0b"),
            VehicleId = Guid.Parse("3f2504e0-4f89-11d3-9a0c-0305e82c3301"),
            FirstName = "Максим",
            LastName = "Лебедев",
            Age = 29,
            Experience = 6,
            Salary = 47000
        },
        new()
        {
            Id = Guid.Parse("e6f5d4c3-b2a1-0f9e-8d7c-6b5a4d3e2f1f"),
            VehicleId = Guid.Parse("d5a8f8e0-4f3b-11eb-ae93-0242ac130002"),
            FirstName = "Владимир",
            LastName = "Новиков",
            Age = 37,
            Experience = 14,
            Salary = 58000
        },
        new()
        {
            Id = Guid.Parse("1a0b9c8d-7e6f-5a4b-3c2d-1e0f9a8b7c6d"),
            VehicleId = Guid.Parse("2ab8c430-85f3-11eb-8dcd-0242ac120003"),
            FirstName = "Андрей",
            LastName = "Козлов",
            Age = 40,
            Experience = 17,
            Salary = 61000
        },
        new()
        {
            Id = Guid.Parse("f0e1d2c3-4b5a-6d7e-8f9a-0b1c2d3e4f5a"),
            VehicleId = Guid.Parse("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
            FirstName = "Олег",
            LastName = "Морозов",
            Age = 33,
            Experience = 9,
            Salary = 54000
        }
    ];

    public async Task<List<Driver>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return _drivers;
    }

    public async Task CreateDriverAsync(Driver driver, CancellationToken cancellationToken = default)
    {
        _drivers.Add(driver);
    }
}