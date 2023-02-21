using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Service.Authentication;

public record AuthenticationResult(
  User user,
  string Token
);