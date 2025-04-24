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

    public Task<EntityId> Handle(CreateRouteCommand request, CancellationToken cancellationToken)
    {
        
    }
}