using MediatR;

namespace Shipping.Application.Transportations.Queries.GetTransportations;

public class GetTransportationsQuery : IRequest<List<TransportationsDto>>
{
}