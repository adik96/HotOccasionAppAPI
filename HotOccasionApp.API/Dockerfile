FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["HotOccasionApp.API/HotOccasionApp.API.csproj", "HotOccasionApp.API/"]
RUN dotnet restore "HotOccasionApp.API/HotOccasionApp.API.csproj"
COPY . .
WORKDIR "/src/HotOccasionApp.API"
RUN dotnet build "HotOccasionApp.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HotOccasionApp.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HotOccasionApp.API.dll"]