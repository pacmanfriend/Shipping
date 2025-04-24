using MediatR;
using Shipping.Domain.Common.ValueObjects;

namespace Shipping.Application.Routes.Commands.CreateRoute;

public record CreateRouteCommand : IRequest<EntityId>
{
    public string RouteTitle { get; init; }
    public string CityFrom { get; init; }
    public string CityTo { get; init; }
    public TimeSpan EstimatedTime { get; init; }
    public double Price { get; init; }
    public double Distance { get; init; }
}