FROM mcr.microsoft.com/dotnet/aspnet:8.0-preview-jammy AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0-preview-jammy AS build
WORKDIR /src
COPY ["Volcano.Api.csproj", "Volcano.Api.csproj"]
RUN dotnet restore "Volcano.Api.csproj"
COPY . .
RUN dotnet build "Volcano.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Volcano.Api.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "Volcano.Api.dll"]
