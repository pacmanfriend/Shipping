using MediatR;
using Shipping.Domain.Vehicle;

namespace Shipping.Application.Vehicles.Queries.GetAllVehicles;

public record GetAllVehiclesQuery : IRequest<List<Vehicle>>
{
}