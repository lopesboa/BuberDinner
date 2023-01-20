using BuberDinner.Application;
using BuberDinner.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services
    .AddApplication()
    .AddInfrastructure(builder.Configuration);
  builder.Services.AddControllers();
  builder.Services.AddHealthChecks();
}

var app = builder.Build();
{
  app.MapHealthChecks("/health");
  app.UseHttpsRedirection();
  app.MapControllers();
  app.Run();
}
