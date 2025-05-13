using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shipping.Application.Transportations.Commands.CreateTransportation;
using Shipping.Application.Transportations.Queries.GetTransportations;

namespace Shipping.Web.Endpoints;

public static class TransportationsEndpoints
{
    public static void MapTransportationsEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/v1/transportation");

        group.MapGet("", GetTransportations).WithName(nameof(GetTransportations));
        group.MapPost("", CreateTransportation).WithName(nameof(CreateTransportation));
    }

    public static async Task<IResult> GetTransportations(
        [FromServices] IMediator mediator
    )
    {
        var transportations = await mediator.Send(new GetTransportationsQuery());
        return Results.Ok(transportations);
    }

    public static async Task<IResult> CreateTransportation(
        [FromBody] CreateTransportationCommand command,
        [FromServices] IMediator mediator
    )
    {
        await mediator.Send(command);
        return Results.Ok();
    }
}