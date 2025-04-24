using Shipping.Web.Endpoints;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddEndpointsApiExplorer();
}

var app = builder.Build();
{
    app.UseHsts();
    app.UseHttpsRedirection();

    app.MapRoutesEndpoints();

    app.MapGet("/", () => "Hello World!");
}

app.Run();