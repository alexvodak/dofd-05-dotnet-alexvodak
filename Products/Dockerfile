# Use the official Microsoft .NET 6 SDK image for building
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /app

COPY . ./

RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:6.0

WORKDIR /app

COPY --from=build /app/out .

EXPOSE 8080

ENTRYPOINT ["dotnet", "Products.dll"]