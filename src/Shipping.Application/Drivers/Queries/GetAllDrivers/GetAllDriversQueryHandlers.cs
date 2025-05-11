using MediatR;
using Shipping.Domain.Driver;

namespace Shipping.Application.Drivers.Queries.GetAllDrivers;

public class GetAllDriversQueryHandlers : IRequestHandler<GetAllDriversQuery, List<Driver>>
{
    private readonly IDriversRepository _driversRepository;

    public GetAllDriversQueryHandlers(IDriversRepository driversRepository)
    {
        _driversRepository = driversRepository;
    }

    public async Task<List<Driver>> Handle(GetAllDriversQuery request, CancellationToken cancellationToken)
    {
        var drivers = await _driversRepository.GetAllAsync(cancellationToken);

        return drivers;
    }
}