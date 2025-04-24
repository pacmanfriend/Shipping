using MediatR;
using Shipping.Application.Routes.Queries.GetAllRoutes;

namespace Shipping.Web.Endpoints;

public static class RoutesEndpoints
{
    public static void MapRoutesEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/shipping/api/v1/routes")
            .AllowAnonymous();

        group.MapGet("", GetAllRoutes).WithName(nameof(GetAllRoutes));
        group.MapPost("", CreateRoute).WithName(nameof(CreateRoute));
        group.MapPut("", UpdateRoute).WithName(nameof(UpdateRoute));
        group.MapDelete("", DeleteRoute).WithName(nameof(DeleteRoute));
    }

    public static async Task<IResult> GetAllRoutes(IMediator mediator)
    {
        var routes = await mediator.Send(new GetAllRoutesQuery());

        return Results.Ok(routes);
    }

    public static async Task<IResult> CreateRoute(IMediator mediator)
    {
        return Results.Ok();
    }

    public static async Task<IResult> UpdateRoute(IMediator mediator)
    {
        return Results.Ok();
    }

    public static async Task<IResult> DeleteRoute(IMediator mediator)
    {
        return Results.Ok();
    }
}