FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Course.API/Course.API.csproj", "Course.API/"]
COPY ["Course.Application/Course.Application.csproj", "Course.Application/"]
COPY ["SharedModels/SharedModels.csproj", "SharedModels/"]
COPY ["Course.Domain/Course.Domain.csproj", "Course.Domain/"]
COPY ["User.Domain/User.Domain.csproj", "User.Domain/"]
RUN dotnet restore "Course.API/Course.API.csproj"
COPY . .
WORKDIR "/src/Course.API"
RUN dotnet build "Course.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "Course.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Course.API.dll"]
