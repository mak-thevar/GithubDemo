#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["GithubDemo_DF003_04/GithubDemo_DF003_04.csproj", "GithubDemo_DF003_04/"]
RUN dotnet restore "GithubDemo_DF003_04/GithubDemo_DF003_04.csproj"
COPY . .
WORKDIR "/src/GithubDemo_DF003_04"
RUN dotnet build "GithubDemo_DF003_04.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GithubDemo_DF003_04.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GithubDemo_DF003_04.dll"]