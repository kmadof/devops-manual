FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["WeatherService/WeatherService.csproj", "WeatherService/"]
RUN dotnet restore "WeatherService/WeatherService.csproj"
COPY . .
WORKDIR "/src/WeatherService"
RUN dotnet build "WeatherService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeatherService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeatherService.dll"]