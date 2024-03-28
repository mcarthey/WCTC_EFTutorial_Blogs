---
marp: true
theme: wctc
style: |
  @import 'wctc-theme.css';
---
![WCTC Logo](https://www.wctc.edu/_resources/images/waukesha_logo.svg)

# Getting Started with Entity Framework Core
*Instructor: Mark McArthey*

---

## Overview
- Entity Framework Core (EF Core) is a lightweight, extensible, and cross-platform version of Entity Framework.
- It provides a familiar developer experience to previous versions of EF, including LINQ support, change tracking, and more.
---

## First App
- **Step 1:** Install the Entity Framework Core Tools.
- **Step 2:** Create a new console project.
- **Step 3:** Install the EF Core SQL Server provider.
- **Step 4:** Scaffold a DbContext and entities.
- **Step 5:** Use the DbContext to interact with the database.
---

## Install the EF Core Tools

```csharp
dotnet tool install --global dotnet-ef
```
---
## Create a New Console Project
```csharp
dotnet new console -n MyFirstEFCoreApp
cd MyFirstEFCoreApp
```
---
## Install the EF Core SQL Server Provider
```csharp
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```
- This package is the SQL Server database provider for Entity Framework Core. It allows your application to communicate with SQL Server databases using EF Core.

---
## Install other necessary libraries
```csharp
dotnet add package Microsoft.EntityFrameworkCore.Proxies
```
- This package enables the creation of proxy classes for Entity Framework Core. Proxy classes are derived from your entity classes and can override virtual properties to include behaviors like lazy loading.
- Remember that while lazy loading can be convenient, it can also lead to performance issues if not used carefully, as it can result in more database queries than expected.
```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseLazyLoadingProxies();
}
```
---
## Install other necessary libraries
```csharp
dotnet add package Microsoft.EntityFrameworkCore.Design
```
- This package provides shared design-time components for Entity Framework Core tools.  This package is necessary for running EF Core commands like `dotnet ef migrations add`, `dotnet ef database update`, and others. These commands are used to create and manage database migrations.  This package is typically included as a development dependency, as it's not needed for the application to run, but is needed for development tasks like creating and applying database migrations.
---
## Install other necessary libraries
```csharp
dotnet add package Microsoft.Extensions.Configuration.Json
```
- This package allows an application to read configuration data from JSON files. It's commonly used to load settings from `appsettings.json` and `appsettings.{Environment}.json` files in ASP.NET Core applications.
---
## Install other necessary libraries
```csharp
dotnet add package Microsoft.Extensions.DependencyInjection
```
- This package is part of the ASP.NET Core framework and provides a default inversion of control (IoC) container for registering and resolving dependencies.  This package provides a lightweight, minimalistic dependency injection (DI) container that supports constructor injection by default. It's used to add and configure services in ASP.NET Core applications.
```csharp
public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<MyDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
}
```
---

## Scaffold a DbContext and Entities
```csharp
dotnet ef dbcontext scaffold "Server=<server>;Database=<database>;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models
```
---
## Use the DbContext to Interact with the Database
```csharp
using (var context = new MyDbContext())
{
    var blogs = context.Blogs.ToList();
}

```
---
## Summary

- Entity Framework Core is a powerful ORM framework for .NET applications.
- Getting started with EF Core is easy and can be done in a few simple steps.
- EF Core provides a familiar developer experience with support for LINQ and change tracking.

---

## Useful Links

- [Getting Started with EF Core](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app)
- [Reverse Engineering a Database](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding)
- [ConnectionStrings](https://www.connectionstrings.com)
- [EF Core Image](./efcore.png)