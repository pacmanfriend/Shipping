using MediatR;
using Shipping.Domain.Driver;

namespace Shipping.Application.Drivers.Queries.GetAllDrivers;

public record GetAllDriversQuery : IRequest<List<Driver>>
{
    
}