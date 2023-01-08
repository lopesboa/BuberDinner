namespace BuberDinner.Application.Service.Authentication;

public record AuthenticationResult(
  Guid Id,
  string FirstName,
  string LastName,
  string Email,
  string Token
);