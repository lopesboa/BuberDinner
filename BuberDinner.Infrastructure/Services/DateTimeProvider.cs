namespace BuberDinner.Infrastructure.Services;

using System;
using BuberDinner.Application.Common.Interfaces.Services;

public class DateTimeProvider : IDateTimeProvider
{
  public DateTime UtcNow => DateTime.UtcNow;

}