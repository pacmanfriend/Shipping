using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shipping.Application.Vehicles.Commands.CreateVehicle;
using Shipping.Application.Vehicles.Queries.GetAllVehicles;

namespace Shipping.Web.Endpoints;

public static class VehiclesEndpoints
{
    public static void MapVehiclesEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/v1/vehicles")
            .AllowAnonymous();

        group.MapGet("", GetAllVehicles).WithName(nameof(GetAllVehicles));
        group.MapPost("", CreateVehicle).WithName(nameof(CreateVehicle));
        group.MapDelete("/{id}", DeleteVehicle).WithName(nameof(DeleteVehicle));
    }

    public static async Task<IResult> GetAllVehicles(
        [FromServices] IMediator mediator
    )
    {
        var vehicles = await mediator.Send(new GetAllVehiclesQuery());
        return Results.Ok(vehicles);
    }

    public static async Task<IResult> CreateVehicle(
        [FromBody] CreateVehicleCommand command,
        [FromServices] IMediator mediator
    )
    {
        var vehicleId = await mediator.Send(command);

        return Results.Ok(vehicleId);
    }

    public static async Task<IResult> DeleteVehicle(
        string id,
        [FromServices] IMediator mediator
    )
    {
        return Results.Ok();
    }
}