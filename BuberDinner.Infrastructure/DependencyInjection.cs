namespace BuberDinner.Infrastructure;

using BuberDinner.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using BuberDinner.Infrastructure.Authentication;
using BuberDinner.Application.Common.Interfaces.Services;
using BuberDinner.Application.Common.Interfaces.Authentication;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
    services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
    return services;
  }
}