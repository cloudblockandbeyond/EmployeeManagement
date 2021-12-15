FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY Backend.Api.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish --configuration Release --output /app

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
WORKDIR /app
EXPOSE 80/tcp
COPY --from=build /app .
ENTRYPOINT ["dotnet", "Backend.Api.dll"]