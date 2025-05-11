using MediatR;

namespace Shipping.Application.Drivers.Commands.CreateDriver;

public record CreateDriverCommand : IRequest
{
    public string FirstName { get; init; }
    public string LastName { get; init; }
    public int Age { get; init; }
    public int Experience { get; init; }
    public double Salary { get; init; }
}