#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /var/www/
EXPOSE 41089

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["GSLAB3.MVC.csproj", "./"]
RUN dotnet restore "./GSLAB3.MVC.csproj"
COPY . .
RUN dotnet build "GSLAB3.MVC.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GSLAB3.MVC.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GSLAB3.MVC.dll"]