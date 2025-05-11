using MediatR;
using Shipping.Domain.Driver;

namespace Shipping.Application.Drivers.Commands.CreateDriver;

public class CreateDriverCommandHandler : IRequestHandler<CreateDriverCommand>
{
    private readonly IDriversRepository _driversRepository;

    public CreateDriverCommandHandler(IDriversRepository driversRepository)
    {
        _driversRepository = driversRepository;
    }

    public async Task Handle(CreateDriverCommand request, CancellationToken cancellationToken)
    {
        var driver = new Driver()
        {
            Id = Guid.NewGuid(),
            FirstName = request.FirstName,
            LastName = request.LastName,
            Age = request.Age,
            Experience = request.Experience,
            Salary = request.Salary,
        };

        await _driversRepository.CreateDriverAsync(driver, cancellationToken);
    }
}