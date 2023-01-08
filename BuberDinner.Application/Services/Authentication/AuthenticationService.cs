namespace BuberDinner.Application.Service.Authentication;

public class AuthenticationService : IAuthenticationService
{
  public AuthenticationResult Login(string email, string password)
  {
    return new AuthenticationResult(
      Guid.NewGuid(), 
      "FirstName", 
      "LastName", 
      email, 
      "Token"
    );
  }

  public AuthenticationResult Register(string firstName, string lastName, string email, string password)
  {
    return new AuthenticationResult(
      Guid.NewGuid(),
      firstName,
      lastName,
      email,
      "Token"
    );
  }
}