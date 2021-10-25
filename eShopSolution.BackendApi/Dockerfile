#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["eShopSolution.BackendApi/eShopSolution.BackendApi.csproj", "eShopSolution.BackendApi/"]
COPY ["eShopSolution.Application/eShopSolution.Application.csproj", "eShopSolution.Application/"]
COPY ["eShopSolution.Utilities/eShopSolution.Utilities.csproj", "eShopSolution.Utilities/"]
COPY ["eShopSolution.ViewModels/eShopSolution.ViewModels.csproj", "eShopSolution.ViewModels/"]
COPY ["eShopSolution.Data/eShopSolution.Data.csproj", "eShopSolution.Data/"]
COPY ["eShopSolution.AdminApp/eShopSolution.AdminApp.csproj", "eShopSolution.AdminApp/"]
COPY ["eShopSolution.ApiIntegration/eShopSolution.ApiIntegration.csproj", "eShopSolution.ApiIntegration/"]
RUN dotnet restore "eShopSolution.BackendApi/eShopSolution.BackendApi.csproj"
COPY . .
WORKDIR "/src/eShopSolution.BackendApi"
RUN dotnet build "eShopSolution.BackendApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "eShopSolution.BackendApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "eShopSolution.BackendApi.dll"]