#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Accommodation/Accommodation.Presentation/Accommodation.Presentation.csproj", "src/Accommodation/Accommodation.Presentation/"]
COPY ["src/Accommodation/Accommodation.Application/Accommodation.Application.csproj", "src/Accommodation/Accommodation.Application/"]
COPY ["src/Accommodation/Accommodation.Domain/Accommodation.Domain.csproj", "src/Accommodation/Accommodation.Domain/"]
COPY ["src/Accommodation/Accommodation.Infrastructure/Accommodation.Infrastructure.csproj", "src/Accommodation/Accommodation.Infrastructure/"]
RUN dotnet restore "src/Accommodation/Accommodation.Presentation/Accommodation.Presentation.csproj"
COPY . .
WORKDIR "/src/src/Accommodation/Accommodation.Presentation"
RUN dotnet build "Accommodation.Presentation.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Accommodation.Presentation.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Accommodation.Presentation.dll"]