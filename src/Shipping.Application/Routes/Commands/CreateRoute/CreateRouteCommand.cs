using MediatR;
using Shipping.Domain.Common.ValueObjects;

namespace Shipping.Application.Routes.Commands.CreateRoute;

public record CreateRouteCommand : IRequest<EntityId>
{
    /// <summary>
    /// Название маршрута
    /// </summary>
    public string RouteTitle { get; init; }
    /// <summary>
    /// Название города, откуда будет начало маршрута
    /// </summary>
    public string CityFrom { get; init; }
    /// <summary>
    /// Название города, где будет конец маршрута
    /// </summary>
    public string CityTo { get; init; }
    /// <summary>
    /// Стоимость перевозки по этому маршруту
    /// </summary>
    public double Price { get; init; }
    /// <summary>
    /// Валюта
    /// </summary>
    public string Currency { get; init; }
    /// <summary>
    /// Расстояние
    /// </summary>
    public double Distance { get; init; }
    /// <summary>
    /// Система измерения расстояния
    /// </summary>
    public string DistanceDimension { get; init; }
    /// <summary>
    /// Рассчетное время маршрута
    /// </summary>
    public string EstimatedTime { get; init; }
}