FROM mcr.microsoft.com/dotnet/aspnet:9.0 as base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

COPY ["CartasService.csproj","./"]
RUN dotnet restore "./CartasService.csproj"

COPY . .
RUN dotnet publish "CartasService.csproj" -c Release -o /app/publish

FROM base as final
WORKDIR /app

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "CartasService.dll"]