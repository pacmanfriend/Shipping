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

    public static async Task<IResult> GetAllRoutes()
    {
        return Results.Ok();
    }

    public static async Task<IResult> CreateRoute()
    {
        return Results.Ok();
    }

    public static async Task<IResult> UpdateRoute()
    {
        return Results.Ok();
    }

    public static async Task<IResult> DeleteRoute()
    {
        return Results.Ok();
    }
}