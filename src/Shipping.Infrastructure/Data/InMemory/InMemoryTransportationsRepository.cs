using Shipping.Domain.Transportation;

namespace Shipping.Infrastructure.Data.InMemory;

public class InMemoryTransportationsRepository : ITransportationsRepository
{
    private readonly List<Transportation> _transportations =
    [
        new()
        {
            Id = Guid.Parse("2a02f4e9-144a-4611-bbad-70e95a9607af"),
            DriverId = Guid.Parse("e7d8e9f0-a1b2-4c3d-8e5f-6a7b8c9d0e1f"),
            RouteId = Guid.Parse("2a9c8d45-b01f-4b7a-9a2c-5e8d6f3a1d01"),
            CreatedAt = new DateTimeOffset(2024, 11, 1, 10, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 11, 3, 8, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 5, 14, 0, 0, TimeSpan.Zero),
            ShippingStatus = "In Transit",
            TotalPrice = 4500.75,
            Cargos =
            [
                new Cargo { Title = "Electronics", Description = "Smartphones and tablets", Weight = 250.5 },
                new Cargo { Title = "Furniture", Description = "Office chairs", Weight = 600.0 }
            ]
        },
        new()
        {
            Id = Guid.Parse("8c93a47e-77b5-425d-8d65-8737f0600c8d"),
            DriverId = Guid.Parse("e7d8e9f0-a1b2-4c3d-8e5f-6a7b8c9d0e1f"),
            RouteId = Guid.Parse("7c6d3a1b-2e8f-4d5c-9b7a-0cfd2e1a8d3b"),
            CreatedAt = new DateTimeOffset(2024, 10, 25, 9, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 10, 27, 7, 30, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 10, 30, 18, 0, 0, TimeSpan.Zero),
            ShippingStatus = "Delivered",
            TotalPrice = 3200.00,
            Cargos =
            [
                new Cargo { Title = "Clothes", Description = "Winter jackets", Weight = 120.0 }
            ]
        },
        new()
        {
            Id = Guid.Parse("30870946-0c7d-4b2c-a699-e00af5b882c1"),
            DriverId = Guid.Parse("e7d8e9f0-a1b2-4c3d-8e5f-6a7b8c9d0e1f"),
            RouteId = Guid.Parse("4f3c8e6d-7a5b-4b3c-8d4e-1a2f9c0d7e5f"),
            CreatedAt = new DateTimeOffset(2024, 11, 2, 11, 15, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 11, 4, 9, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 7, 10, 0, 0, TimeSpan.Zero),
            ShippingStatus = "Pending",
            TotalPrice = 7800.99,
            Cargos =
            [
                new Cargo { Title = "Machinery", Description = "Industrial equipment", Weight = 950.25 },
                new Cargo { Title = "Tools", Description = "Hand tools", Weight = 300.75 },
                new Cargo { Title = "Chemicals", Description = "Industrial solvents", Weight = 420.0 }
            ]
        },
        new()
        {
            Id = Guid.Parse("8f9fbb01-f1ad-4951-a038-d062a1b640f4"),
            DriverId = Guid.Parse("9a8b7c6d-5e4f-3a2b-1c0d-9e8f7a6b5c4d"),
            RouteId = Guid.Parse("b1a2c3d4-e5f6-7890-a1a2-a3a4b5a6a7a8"),
            CreatedAt = new DateTimeOffset(2024, 10, 30, 14, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 11, 1, 10, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 5, 16, 0, 0, TimeSpan.Zero),
            ShippingStatus = "Delayed",
            TotalPrice = 2750.00,
            Cargos = [new Cargo { Title = "Food Products", Description = "Frozen vegetables", Weight = 800.0 }]
        },
        new()
        {
            Id = Guid.Parse("d7c86403-66c3-48b7-9f2f-86a9dab745e6"),
            DriverId = Guid.Parse("9a8b7c6d-5e4f-3a2b-1c0d-9e8f7a6b5c4d"),
            RouteId = Guid.Parse("9d8e7c6b-5a4f-3e2d-1c0b-fdca98765432"),
            CreatedAt = new DateTimeOffset(2024, 11, 3, 12, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 11, 5, 8, 30, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 8, 12, 0, 0, TimeSpan.Zero),
            ShippingStatus = "In Transit",
            TotalPrice = 5600.50,
            Cargos =
            [
                new Cargo { Title = "Books", Description = "Educational literature", Weight = 150.0 },
                new Cargo { Title = "Toys", Description = "Children's toys", Weight = 180.0 }
            ]
        },
        new()
        {
            Id = Guid.Parse("52e97065-87b2-439e-81c9-7d0076320da3"),
            DriverId = Guid.Parse("0f1e2d3c-4b5a-6978-8f9e-0d1c2b3a4958"),
            RouteId = Guid.Parse("ee1f2d3c-4b5a-6d7e-8f9c-a0b1c2d3e4f5"),
            CreatedAt = new DateTimeOffset(2024, 10, 28, 10, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 10, 30, 9, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 2, 14, 0, 0, TimeSpan.Zero),
            ShippingStatus = "Delivered",
            TotalPrice = 3100.00,
            Cargos = [new Cargo { Title = "Medical Supplies", Description = "Syringes and bandages", Weight = 320.0 }]
        },
        new()
        {
            Id = Guid.Parse("b35d63cd-1230-4f03-b697-7d862e151234"),
            DriverId = Guid.Parse("0f1e2d3c-4b5a-6978-8f9e-0d1c2b3a4958"),
            RouteId = Guid.Parse("a1b2c3d4-d5e6-f7a8-b9c0-d1e2f3a4b5c6"),
            CreatedAt = new DateTimeOffset(2024, 11, 4, 13, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 11, 6, 11, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 9, 10, 0, 0, TimeSpan.Zero),
            ShippingStatus = "In Transit",
            TotalPrice = 6700.25,
            Cargos =
            [
                new Cargo { Title = "Automotive Parts", Description = "Car engines", Weight = 700.0 },
                new Cargo { Title = "Packaging Materials", Description = "Boxes and foam", Weight = 400.0 }
            ]
        },
        new()
        {
            Id = Guid.Parse("da79572b-f948-438c-b9df-510ce0e51eac"),
            DriverId = Guid.Parse("0f1e2d3c-4b5a-6978-8f9e-0d1c2b3a4958"),
            RouteId = Guid.Parse("f0e1d2c3-b5a4-7d6e-9f8c-7b2a1c0d9e5f"),
            CreatedAt = new DateTimeOffset(2024, 10, 26, 15, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 10, 28, 12, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 1, 18, 0, 0, TimeSpan.Zero),
            ShippingStatus = "Delivered",
            TotalPrice = 2900.00,
            Cargos = [new Cargo { Title = "Paper Products", Description = "Notebooks and papers", Weight = 200.0 }]
        },
        new()
        {
            Id = Guid.Parse("7ada103a-7b8d-472a-97ea-5ece3a984170"),
            DriverId = Guid.Parse("a0b1c2d3-e4f5-6a7b-8c9d-0e1f2a3b4c5d"),
            RouteId = Guid.Parse("ee1f2d3c-4b5a-6d7e-8f9c-a0b1c2d3e4f5"),
            CreatedAt = new DateTimeOffset(2024, 11, 5, 10, 30, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 11, 7, 9, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 10, 15, 0, 0, TimeSpan.Zero),
            ShippingStatus = "Pending",
            TotalPrice = 4100.99,
            Cargos =
            [
                new Cargo { Title = "Glassware", Description = "Kitchen glasses", Weight = 100.0 },
                new Cargo { Title = "Artwork", Description = "Paintings", Weight = 150.0 }
            ]
        },
        new()
        {
            Id = Guid.Parse("c9b1af1b-a01b-4a44-8e9d-6058d9f6c514"),
            DriverId = Guid.Parse("a0b1c2d3-e4f5-6a7b-8c9d-0e1f2a3b4c5d"),
            RouteId = Guid.Parse("ee1f2d3c-4b5a-6d7e-8f9c-a0b1c2d3e4f5"),
            CreatedAt = new DateTimeOffset(2024, 10, 31, 14, 0, 0, TimeSpan.Zero),
            DepartureDate = new DateTimeOffset(2024, 11, 2, 8, 0, 0, TimeSpan.Zero),
            ArrivalDate = new DateTimeOffset(2024, 11, 6, 17, 0, 0, TimeSpan.Zero),
            ShippingStatus = "Delayed",
            TotalPrice = 3300.00,
            Cargos = [new Cargo { Title = "Electrical Equipment", Description = "Switches and cables", Weight = 500.0 }]
        }
    ];

    public async Task<List<Transportation>> GetTransportationsAsync(CancellationToken cancellationToken = default)
    {
        return _transportations;
    }

    public async Task CreateTransportationAsync(
        Transportation transportation,
        CancellationToken cancellationToken = default
    )
    {
        _transportations.Add(transportation);
    }
}