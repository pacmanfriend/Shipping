using MediatR;
using Shipping.Domain.Common.ValueObjects;
using Shipping.Domain.Route;

namespace Shipping.Application.Routes.Commands.CreateRoute;

public class CreateRouteCommandHandler : IRequestHandler<CreateRouteCommand, EntityId>
{
    private readonly IRoutesRepository _routesRepository;

    public CreateRouteCommandHandler(IRoutesRepository routesRepository)
    {
        _routesRepository = routesRepository;
    }

    public async Task<EntityId> Handle(CreateRouteCommand request, CancellationToken cancellationToken)
    {
        var route = new Route.Builder()
            .WithNewId()
            .WithTitle(request.RouteTitle)
            .WithDestination(request.CityFrom, request.CityTo)
            .WithDistance(request.Distance, request.Dimension)
            .WithEstimatedTime(request.EstimatedTime)
            .WithPrice(request.Price, request.Currency)
            .Build();

        var createdRouteId = await _routesRepository.CreateRoute(route, cancellationToken);

        return createdRouteId;
    }
}