# CoreApiFundamentals
Using SQL Liter for this project
dotnet add package Microsoft.EntityFrameworkCore.SQLite

#Migrations
dotnet tool install --global dotnet-ef --version 3.0.0
dotnet ef --startup-project core-web-api\core-web-api.csproj migrations add InitialModel -p MyApi.Data\MyApi.Data.csproj
dotnet ef --startup-project core-web-api\core-web-api.csproj database update