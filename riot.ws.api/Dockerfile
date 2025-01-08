# Usamos una imagen base de .NET para ASP.NET en Linux
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

# Usamos una imagen base de .NET SDK en Linux para compilar el proyecto
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["riot.ws.api/riot.ws.api.csproj", "riot.ws.api/"]
RUN dotnet restore "./riot.ws.api/riot.ws.api.csproj"
COPY . .
WORKDIR "/src/riot.ws.api"
RUN dotnet build "./riot.ws.api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publicamos la aplicación
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./riot.ws.api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Usamos la imagen base para producción en Linux
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "riot.ws.api.dll"]
