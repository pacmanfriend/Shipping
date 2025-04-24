using Shipping.Application;
using Shipping.Web.Endpoints;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplicationServices();

    builder.Services.AddEndpointsApiExplorer();
}

var app = builder.Build();
{
    app.UseHsts();
    app.UseHttpsRedirection();

    app.MapRoutesEndpoints();

    app.MapGet("/", () => "Welcome to the Shipping!");
}

app.Run();