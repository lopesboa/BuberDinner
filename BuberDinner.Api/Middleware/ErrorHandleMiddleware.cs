using System.Net;
using System.Text.Json;

namespace BuberDinner.Api.Middleware;

public class ErrorHandleMiddleware
{
  private readonly RequestDelegate _next;

  public ErrorHandleMiddleware(RequestDelegate next) 
  {
    _next = next;
  }

  public async Task Invoke(HttpContext context)
  {
    try
    {
      await _next(context);
    }
    catch (Exception ex)
    {
      await HandleExceptionAsync(context, ex);
    }
  }

  private Task HandleExceptionAsync(HttpContext context, Exception ex)
  {
   var code = HttpStatusCode.InternalServerError;
   var result = JsonSerializer.Serialize(new {error = "An error occurred while processing your request."});
   context.Response.ContentType = "application/json";
   context.Response.StatusCode = (int)code;
   return context.Response.WriteAsync(result);

  }

}