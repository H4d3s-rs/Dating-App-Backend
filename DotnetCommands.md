### .NET 

#### Commands

```bash
dotnet run                       # <- run the application
dotnet watch                     # <- run the application with debug info

dotnet new <command>             # <- Create a new context
dotnet new 
dotnet new wepapi                # <- Dotnet new webapi
dotnet new webapi -controllers   # <- Dotnet webapi with controllers
dotnet new gitignore             # <- Create a new gitignore
dotnet new sln                   # <- Creates a new solution file

dotnet sln add <path/file-name>  # <- Add a file into the solution file

dotnet tool list -g              # <- List the tools installed in a global enviroment
dotnet tool install -g <name-tool> --version=*.*  # <- Install the tool on version specified
```


#### Dotnet EntityFramework Tool CLI

```bash
# dotnet-ef is used to create and make the migrations into the database

dotnet tool install -g dotnet-ef --version=9.0.5
dotnet-ef migrations add <name> -o <path/name>
dotnet-ef database update 
```


#### Developing Process

```txt
LibInstallation -> EntityDefinition -> DbContextSetup -> Migrations -> ServicesWriting -> ControllerWriting

```


#### EntityFramework Database operations

```csharp

_context.ModelName.ToList();                                     // | - Select all and convert into a list 
_context.ModelName.ToListAsync();                                // |

_context.ModelName.FirstOrDefault(x => x.Column == data)         // | - Select with where and return the result
_context.ModelName.FirstOrDefaultAsync(x => x.Column == data)    // |

_context.ModelName.Add(ModelObjectVar);                          // | - Insert into the database
_context.ModelName.Remove(ModelObjectVar);                       // | - Delete from the database 
_context.ModelName.Update(ModelObjectVar);                       // | - Update into the database

_context.SaveChanges();                                          // |- Execute the operations on database;
_context.SaveChangesAsync();                                     // |

```


---


## Entities or Models

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

DbContext is the main class on EntityFramework used to handle all database, in this case we need to register our tables using DbSet (Remember to make data migrations using dotnet-ef tool).

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
namespace NameOfTheController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class nameController : ControllerBase
    {

        private readonly InterfaceOfService _nameInterfaceServiceVar;

        public EmployeeController(InterfaceOfService nameInterfaceServiceVar)
        {
            _nameInterfaceServiceVar = nameInterfaceServiceVar;

        } 

        [HttpGet]
        public async Task<ActionResult<ServiceClassName<List<NameModel>>>> functionName()
        {
            return Ok( await _nameInterfaceServiceVar.nameFromfunctionofTheInterface());

        }
    }
}
``` 


## Interfaces
Used to "Pre-define" Functions that will be write on **Services section** and consequently used on **Controllers section**

```csharp

public interface InterfaceNameService
{
    Task<ServiceClassName<List<NameModel>>> function1(); 

    Task<ServiceClassName<List<NameModel>>> function2(NameModel name);

    Task<ServiceClassName<NameModel>> function3(int id);

    Task<ServiceClassName<List<NameModel>>> function4(NameModel name);

    Task<ServiceClassName<List<NameModel>>> function5(int id);

    Task<ServiceClassName<List<NameModel>>> function6(int id);

}

```


## Services
Used to implement the logic of the functions defined on the interfaces and consequently use it on controllers section to keep the controller section more clean.

```csharp
public class nameService : InterfaceNameService
{
    private readonly ApplicationDbContext _context;

    public nameService(ApplicationDbContext context)
    {
        _context = context;  

    }

    public async Task<ServiceClassName<List<NameModel>>> GetEmployes()
    {
        ServiceClassName<List<NameModel>> serviceResponse = new ServiceClassName<List<NameModel>>();

        try
        {
            serviceResponse.data = _context.DataFromModel.ToList();

            if (serviceResponse.data.Count == 0)
            {
                serviceResponse.message = "No data found!";

            }

        }catch (Exception ex)
        {
            serviceResponse.message = ex.Message;
            serviceResponse.success = false;
        }

        return serviceResponse;
    }
}

```
