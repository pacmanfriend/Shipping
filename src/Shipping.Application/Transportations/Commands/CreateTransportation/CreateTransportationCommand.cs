using MediatR;
using Shipping.Domain.Transportation;

namespace Shipping.Application.Transportations.Commands.CreateTransportation;

public record CreateTransportationCommand : IRequest
{
    public Guid RouteId { get; init; }
    public Guid DriverId { get; init; }
    public List<Cargo> Cargos { get; init; }
    public DateTimeOffset DepartureDate { get; init; }
    public DateTimeOffset ArrivalDate { get; init; }
}