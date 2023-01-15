FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DeejpotterBlazorServer/DeejpotterBlazorServer.csproj", "DeejpotterBlazorServer/"]
RUN dotnet restore "DeejpotterBlazorServer/DeejpotterBlazorServer.csproj"
COPY . .
WORKDIR "/src/DeejpotterBlazorServer"
RUN dotnet build "DeejpotterBlazorServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DeejpotterBlazorServer.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DeejpotterBlazorServer.dll"]
