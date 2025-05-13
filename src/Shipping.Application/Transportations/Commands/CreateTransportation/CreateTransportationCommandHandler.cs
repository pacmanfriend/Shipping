using MediatR;
using Shipping.Domain.Route;
using Shipping.Domain.Transportation;

namespace Shipping.Application.Transportations.Commands.CreateTransportation;

public class CreateTransportationCommandHandler : IRequestHandler<CreateTransportationCommand>
{
    private readonly ITransportationsRepository _transportationsRepository;
    private readonly IRoutesRepository _routesRepository;

    public CreateTransportationCommandHandler(
        ITransportationsRepository transportationsRepository,
        IRoutesRepository routesRepository
    )
    {
        _transportationsRepository = transportationsRepository;
        _routesRepository = routesRepository;
    }

    public async Task Handle(CreateTransportationCommand request, CancellationToken cancellationToken)
    {
        var route = await _routesRepository.GetRoute(request.RouteId, cancellationToken);

        var transportation = new Transportation()
        {
            RouteId = request.RouteId,
            DriverId = request.DriverId,
            CreatedAt = DateTimeOffset.Now,
            DepartureDate = request.DepartureDate,
            ArrivalDate = request.DepartureDate + route.EstimatedTime,
            Cargos = request.Cargos,
            TotalPrice = route.BasePrice.Value + request.Cargos.Count * 100,
        };

        await _transportationsRepository.CreateTransportationAsync(transportation, cancellationToken);
    }
}