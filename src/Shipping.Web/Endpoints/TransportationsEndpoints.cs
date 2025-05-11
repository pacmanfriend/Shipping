using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        return Results.Ok();
    }

    public static async Task<IResult> CreateTransportation(
        [FromServices] IMediator mediator
    )
    {
        return Results.Ok();
    }
}