using Shipping.Application;
using Shipping.Web.Endpoints;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddApplicationServices();

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

    app.MapRoutesEndpoints();

    app.MapGet("/", () => "Welcome to the Shipping!");
}

app.Run();