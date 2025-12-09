### .NET 

#### Commands

```bash
dotnet run                       # <- run the application
dotnet watch                     # <- run the application with debug info

dotnet new <command>             # <- Create a new context
dotnet new 
dotnet new wepapi                # <- Dotnet new webapi
dotnet new gitignore             # <- Create a new gitignore
dotnet new sln                   # <- Creates a new solution file

dotnet sln add <path/file-name>  # <- Add a file into the solution file

dotnet tool list -g              # <- List the tools installed in a global enviroment
dotnet tool install -g <name-tool> --version=*.*  # <- Install the tool on version specified
```

## Entities

C# classes that representes tables in a Database, e class is a table and the atributes is the columns.

```csharp
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
```

## DbContext

DbContexto is the main class on EntityFramework used to handle all database, in this case we need to register our tables using DbSet (Remember to make data migrations using dotnet-ef tool).

```csharp
public class NameClass : DbContext {
    public NameClass(DbContextOptions options) : base(options) {

    }

    public DbSet<EntityClassName> Users { get; set; }

}
```

## Controllers
That's are handlers of requesitions, processing data and responses.

```csharp


```