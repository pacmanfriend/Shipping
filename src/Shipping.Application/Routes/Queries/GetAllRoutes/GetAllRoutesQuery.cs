using MediatR;
using Shipping.Domain.Route;

namespace Shipping.Application.Routes.Queries.GetAllRoutes;

public record GetAllRoutesQuery : IRequest<List<Route>>
{
}