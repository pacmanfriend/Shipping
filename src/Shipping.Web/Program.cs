using Microsoft.OpenApi.Models;
using Shipping.Application;
using Shipping.Infrastructure;
using Shipping.Web.Endpoints;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplicationServices();
    builder.Services.AddInfrastructureServices();

    builder.Services.AddEndpointsApiExplorer();

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "Shipping API", Version = "v1" });
    });
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHsts();
    app.UseHttpsRedirection();

    var appGroup = app.MapGroup("/shipping/api");

    appGroup.MapRoutesEndpoints();
    appGroup.MapVehiclesEndpoints();
    appGroup.MapDriversEndpoints();
    appGroup.MapTransportationsEndpoints();
}

app.Run();