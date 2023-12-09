#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Hospital/Hospital.Presentation/Hospital.Presentation.csproj", "src/Hospital/Hospital.Presentation/"]
COPY ["src/Hospital/Hospital.Infrastructure/Hospital.Infrastructure.csproj", "src/Hospital/Hospital.Infrastructure/"]
COPY ["src/Hospital/Hospital.Application/Hospital.Application.csproj", "src/Hospital/Hospital.Application/"]
COPY ["src/Hospital/Hospital.Domain/Hospital.Domain.csproj", "src/Hospital/Hospital.Domain/"]
RUN dotnet restore "src/Hospital/Hospital.Presentation/Hospital.Presentation.csproj"
COPY . .
WORKDIR "/src/src/Hospital/Hospital.Presentation"
RUN dotnet build "Hospital.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Hospital.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Hospital.Presentation.dll"]