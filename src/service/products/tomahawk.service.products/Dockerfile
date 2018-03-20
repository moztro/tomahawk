FROM microsoft/aspnetcore:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/service/products/tomahawk.service.products/tomahawk.service.products.csproj src/service/products/tomahawk.service.products/
COPY src/domain/products/tomahawk.domain.products/tomahawk.domain.products.csproj src/domain/products/tomahawk.domain.products/
RUN dotnet restore
COPY . .
WORKDIR /src/src/service/products/tomahawk.service.products
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "tomahawk.service.products.dll"]
