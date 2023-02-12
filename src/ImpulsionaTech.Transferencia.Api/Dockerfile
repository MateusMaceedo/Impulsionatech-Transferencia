FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5213

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/ImpulsionaTech.Transferencia.Api/ImpulsionaTech.Transferencia.Api.csproj", "src/ImpulsionaTech.Transferencia.Api/"]
RUN dotnet restore "src/ImpulsionaTech.Transferencia.Api/ImpulsionaTech.Transferencia.Api.csproj"
COPY . .
WORKDIR "/src/src/ImpulsionaTech.Transferencia.Api"
RUN dotnet build "ImpulsionaTech.Transferencia.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ImpulsionaTech.Transferencia.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ImpulsionaTech.Transferencia.Api.dll"]
