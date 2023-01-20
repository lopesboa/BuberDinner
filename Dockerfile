FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /source
COPY . .
RUN dotnet restore "./BuberDinner.Api/BuberDinner.Api.csproj" --disable-parallel
RUN dotnet publish "./BuberDinner.Api/BuberDinner.Api.csproj" -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app

COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "BuberDinner.Api.dll"]