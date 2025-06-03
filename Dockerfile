# Build
FROM bitnami/dotnet-sdk:latest AS build
WORKDIR /src
COPY Caltec.StudentInfoProject.WebUi/Caltec.StudentInfoProject.WebUi.csproj Caltec.StudentInfoProject.WebUi/
RUN dotnet restore Caltec.StudentInfoProject.WebUi/Caltec.StudentInfoProject.WebUi.csproj
COPY . .
WORKDIR /src/Caltec.StudentInfoProject.WebUi
RUN dotnet publish Caltec.StudentInfoProject.WebUi.csproj -c Release -o /app/publish


# Runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app/publish .
EXPOSE 80
ENTRYPOINT ["dotnet", "Caltec.StudentInfoProject.WebUi.dll"]