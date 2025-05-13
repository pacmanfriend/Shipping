using MediatR;
using Shipping.Domain.Driver;
using Shipping.Domain.Route;
using Shipping.Domain.Transportation;

namespace Shipping.Application.Transportations.Queries.GetTransportations;

public class GetTransportationsQueryHandler : IRequestHandler<GetTransportationsQuery, List<TransportationsDto>>
{
    private readonly ITransportationsRepository _transportationsRepository;
    private readonly IRoutesRepository _routesRepository;
    private readonly IDriversRepository _driversRepository;

    public GetTransportationsQueryHandler(
        ITransportationsRepository transportationsRepository,
        IRoutesRepository routesRepository,
        IDriversRepository driversRepository
    )
    {
        _transportationsRepository = transportationsRepository;
        _routesRepository = routesRepository;
        _driversRepository = driversRepository;
    }

    public async Task<List<TransportationsDto>> Handle(GetTransportationsQuery request,
        CancellationToken cancellationToken)
    {
        var transportations = await _transportationsRepository.GetTransportationsAsync(cancellationToken);
        var drivers = await _driversRepository.GetAllAsync(cancellationToken);
        var routes = await _routesRepository.GetAllRoutes(cancellationToken);

        var transportationDtos = new List<TransportationsDto>();

        foreach (var transportation in transportations)
        {
            var transportationDto = new TransportationsDto()
            {
                RouteTitle = routes.FirstOrDefault(x => x.Id.Value == transportation.RouteId)?.Title.Value!,
                DriverFio = drivers.FirstOrDefault(x => x.Id == transportation.DriverId)!.Fio,
                Cargos = transportation.Cargos,
                DepartureDate = transportation.DepartureDate,
                ArrivalDate = transportation.ArrivalDate,
                TotalPrice = transportation.TotalPrice
            };

            transportationDtos.Add(transportationDto);
        }

        return transportationDtos;
    }
}