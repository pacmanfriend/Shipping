using MediatR;
using Shipping.Domain.Vehicle;

namespace Shipping.Application.Vehicles.Commands.CreateVehicle;

public class CreateVehicleCommandHandler : IRequestHandler<CreateVehicleCommand, Guid>
{
    private readonly IVehiclesRepository _vehiclesRepository;

    public CreateVehicleCommandHandler(IVehiclesRepository vehiclesRepository)
    {
        _vehiclesRepository = vehiclesRepository;
    }

    public async Task<Guid> Handle(CreateVehicleCommand command, CancellationToken cancellationToken)
    {
        var vehicle = new Vehicle()
        {
            Id = Guid.Empty,
            VehicleType = command.VehicleType,
            LicensePlate = command.LicensePlate,
            Payload = command.Payload,
            BodyVolume = command.BodyVolume,
            TechnicalCondition = command.TechnicalCondition,
            LastServiceDate = default,
            FuelConsumption = command.FuelConsumption,
        };

        var id = await _vehiclesRepository.CreateVehicleAsync(vehicle, cancellationToken);

        return id;
    }
}