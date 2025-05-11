using MediatR;
using Shipping.Domain.Vehicle;

namespace Shipping.Application.Vehicles.Queries.GetAllVehicles;

public class GetAllVehiclesQueryHandler : IRequestHandler<GetAllVehiclesQuery, List<Vehicle>>
{
    private readonly IVehiclesRepository _vehiclesRepository;

    public GetAllVehiclesQueryHandler(IVehiclesRepository vehiclesRepository)
    {
        _vehiclesRepository = vehiclesRepository;
    }

    public async Task<List<Vehicle>> Handle(GetAllVehiclesQuery request, CancellationToken cancellationToken)
    {
        var vehicles = await _vehiclesRepository.GetAllAsync(cancellationToken);

        return vehicles;
    }
}