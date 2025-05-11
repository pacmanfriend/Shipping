using MediatR;

namespace Shipping.Application.Transportations.Commands.CreateTransportation;

public class CreateTransportationCommandHandler : IRequestHandler<CreateTransportationCommand>
{
    public async Task Handle(CreateTransportationCommand request, CancellationToken cancellationToken)
    {
        
    }
}