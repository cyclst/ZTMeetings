#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["ZTMeetings.Api/ZTMeetings.Api.csproj", "ZTMeetings.Api/"]
RUN dotnet restore "ZTMeetings.Api/ZTMeetings.Api.csproj"
COPY . .
WORKDIR "/src/ZTMeetings.Api"
RUN dotnet build "ZTMeetings.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ZTMeetings.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ZTMeetings.Api.dll"]