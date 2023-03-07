## Unknown
- Cancellation Tokens
- Request header/body validation
- Best Practices
- Commenting / Documentation
- Repository Pattern

## Project Structure
TL Folders: Controllers | Data | Dtos | Migrations | Models | Services.

Program.cs, AutoMapperProfile.cs

Get VSCode, SQL Server Express, SQL Server Management Studio

## VS Code Extensions
- Material Icon Theme
- C# Extensions (JoshKreativ)
- Prettier

## Importan Commands

    dotnet new webapi

    // Prepare code to add your models + relationships to database
    dotnet ef migrations add MigrationsName
    // Add the migration generated things to the database
    dotnet ef database update

    dotnet watch run
    git init; dotnet new gitignore
    dotnet tool install|update dotnet-ef
    dotnet add package package-name

## Packages for simple API
- AutoMapper.Extensions.Microsoft.DependencyInjection
- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameWorkCore.SQLServer
- Microsoft.EntityFrameWorkCore.Design
  
Authentication Packages:
- Swashbuckle.AspNetCore.Filters
- Microsoft.AspNetCore.Authentication.JwtBearer
  
## Project Config
Add something like this to `appsettings.json`
    
    "ConnectionStrings":{
        "DefaultConnection": "Server=localhost\\SQLEXPRESS01; Database=FormulaZero; Trusted_Connection=true; TrustServerCertificate=true;"
    },

Then add this to `Program.cs` to connect to the database

    builder.Services.AddDbContext<DataContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
