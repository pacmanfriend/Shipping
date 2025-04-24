using MediatR;
using Shipping.Domain.Route;

namespace Shipping.Application.Routes.Queries.GetAllRoutes;

public class GetAllRoutesQueryHandler : IRequestHandler<GetAllRoutesQuery, List<Route>>
{
    private readonly IRoutesRepository _routesRepository;

    public GetAllRoutesQueryHandler(IRoutesRepository repository)
    {
        _routesRepository = repository;
    }

    public async Task<List<Route>> Handle(GetAllRoutesQuery request, CancellationToken cancellationToken)
    {
        return await _routesRepository.GetAllRoutes(cancellationToken);
    }
}