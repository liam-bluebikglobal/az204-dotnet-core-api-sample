# Install packages
```bash
dotnet add package Swashbuckle.AspNetCore
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.Cosmos
```

# Migration
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

# Reference
https://learn.microsoft.com/en-us/training/paths/aspnet-core-minimal-api/