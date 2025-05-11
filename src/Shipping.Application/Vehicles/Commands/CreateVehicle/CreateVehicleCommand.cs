using MediatR;

namespace Shipping.Application.Vehicles.Commands.CreateVehicle;

public record CreateVehicleCommand : IRequest<Guid>
{
    public string VehicleType { get; init; }
    public string LicensePlate { get; init; }
    public double Payload { get; init; }
    public double BodyVolume { get; init; }
    public string TechnicalCondition { get; init; }
    public double FuelConsumption { get; init; }
}