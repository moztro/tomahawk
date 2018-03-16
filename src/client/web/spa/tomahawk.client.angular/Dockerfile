FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/client/web/spa/tomahawk.client.angular/tomahawk.client.angular.csproj src/client/web/spa/tomahawk.client.angular/
RUN dotnet restore
COPY . .
WORKDIR /src/src/client/web/spa/tomahawk.client.angular
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "tomahawk.client.angular.dll"]
