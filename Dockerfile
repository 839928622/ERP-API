# 3.1 (238MB) vs 3.1-alpine (138MB)
FROM mcr.microsoft.com/dotnet/core/sdk:3.1-alpine AS build
# mcr.microsoft.com/dotnet/core/aspnet:3.1 | ASP.NET Core, with runtime only and ASP.NET Core optimizations, on Linux and Windows (multi-arch)
# mcr.microsoft.com/dotnet/core/sdk:3.1    |.NET Core, with SDKs included, on Linux and Windows (multi-arch) | Size after build:238MB
WORKDIR /source

# copy csproj and restore as distinct layers
COPY ERP-API/*.csproj ERP-API/
COPY ERP-API.Test/*.csproj ERP-API.Test/
RUN dotnet restore ERP-API/ERP-API.csproj

# copy and build app and libraries
COPY ERP-API/ ERP-API/

WORKDIR /source/ERP-API/
RUN dotnet build -c release --no-restore

# test stage -- exposes optional entrypoint
# target entrypoint with: docker build --target test
FROM build AS test
WORKDIR /source/tests
COPY ERP-API.Test/ .
ENTRYPOINT ["dotnet", "test", "--logger:trx"]

FROM build AS publish
RUN dotnet publish -c release --no-build -o /app

# final stage/image
# 3.1
FROM mcr.microsoft.com/dotnet/core/runtime:3.1-alpine
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ERP-API.dll"]