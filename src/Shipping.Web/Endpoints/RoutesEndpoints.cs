using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shipping.Application.Routes.Commands.CreateRoute;
using Shipping.Application.Routes.Queries.GetAllRoutes;

namespace Shipping.Web.Endpoints;

public static class RoutesEndpoints
{
    public static void MapRoutesEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var group = endpoints.MapGroup("/v1/routes")
            .AllowAnonymous();

        group.MapGet("", GetAllRoutes).WithName(nameof(GetAllRoutes));
        group.MapPost("", CreateRoute).WithName(nameof(CreateRoute));
        // group.MapPut("", UpdateRoute).WithName(nameof(UpdateRoute));
        // group.MapDelete("/{id}", DeleteRoute).WithName(nameof(DeleteRoute));
    }

    public static async Task<IResult> GetAllRoutes(
        [FromServices] IMediator mediator
    )
    {
        var routes = await mediator.Send(new GetAllRoutesQuery());
        return Results.Ok(routes);
    }

    public static async Task<IResult> CreateRoute(
        [FromBody] CreateRouteCommand createRouteCommand,
        [FromServices] IMediator mediator
    )
    {
        var routeId = await mediator.Send(createRouteCommand);
        return Results.Ok(routeId);
    }

    public static async Task<IResult> UpdateRoute(
        [FromServices] IMediator mediator
    )
    {
        return Results.Ok();
    }

    public static async Task<IResult> DeleteRoute(
        string id,
        [FromServices] IMediator mediator
    )
    {
        return Results.Ok();
    }
}