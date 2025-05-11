using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shipping.Application.Drivers.Commands.CreateDriver;
using Shipping.Application.Drivers.Queries.GetAllDrivers;

namespace Shipping.Web.Endpoints;

public static class DriversEndpoints
{
    public static void MapDriversEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/v1/drivers");

        group.MapGet("", GetDriversAsync).WithName(nameof(GetDriversAsync));
        group.MapPost("", CreateDriverAsync).WithName(nameof(CreateDriverAsync));
    }

    public static async Task<IResult> GetDriversAsync(
        [FromServices] IMediator mediator
    )
    {
        var drivers = await mediator.Send(new GetAllDriversQuery());

        return Results.Ok(drivers);
    }

    public static async Task<IResult> CreateDriverAsync(
        [FromBody] CreateDriverCommand driverCommand,
        [FromServices] IMediator mediator)
    {
        await mediator.Send(driverCommand);

        return Results.Ok();
    }
}