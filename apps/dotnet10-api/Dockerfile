FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src
COPY apps/dotnet10-api/*.csproj ./
RUN dotnet restore ./dotnet10-api.csproj
COPY apps/dotnet10-api/ .
RUN dotnet publish ./dotnet10-api.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
ENV ASPNETCORE_URLS=http://+:8080
COPY --from=build /app/publish .
EXPOSE 8080
ENTRYPOINT ["dotnet", "dotnet10-api.dll"]
