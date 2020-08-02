# PdE-02_OData
**P**rojeto **d**e **E**studo (Study project)

This is a simple project to practice code, especially Open Data Protocol (**OData**).

[Look for more PdE here!](https://github.com/topics/pde-jfrode)

**Tech Stack**
* ASP.NET Core 2.2
* Entity Framework Core
* [OData](https://www.odata.org)

**Sources**
* [Channel 9: Supercharging your Web APIs with OData and ASP.NET Core](https://channel9.msdn.com/Shows/On-NET/Supercharging-your-Web-APIs-with-OData-and-ASPNET-Core)

## Step by step for use OData in your application

* Install NuGet Package ```Microsoft.AspNetCore.OData``` in your project;
* In ```Startup.cs``` add the code below in the ConfigureServices method;
```
// You need this line only if you using dotnet core 3.1
services.AddControllers(mvcOptions =>
                mvcOptions.EnableEndpointRouting = false);

services.AddOData();
```

* In ```Startup.cs```, add the code below in the Configure method:
```
app.UseMvc(routeBuilder =>
    {
        routeBuilder.EnableDependencyInjection();
        routeBuilder.Expand().Select().Count().OrderBy();
    });
```
* Put [EnableQuery()] data annotation in your methods for enable OData;
* Done.


## Examples

### Example 1
**GET:**```https://localhost:44395/Student```

**Result:**
```
[
    {
        "id": "cd82fe53-b57d-4ff1-a4e9-2c7a4de7f173",
        "name": "João Felipe",
        "score": 637,
        "schoolClassId": "0f86e317-cae0-49a0-b539-f80b6f29f4b6",
        "schoolClass": null
    },
    {
        "id": "4d73e48c-2b0b-4c15-a6e9-3e58fe37b54c",
        "name": "Mario Bros Da Silva",
        "score": 555,
        "schoolClassId": "0f86e317-cae0-49a0-b539-f80b6f29f4b6",
        "schoolClass": null
    },
    {
        "id": "2c2b125f-c86a-42b8-9689-4125565d990c",
        "name": "Solid Snake",
        "score": 830,
        "schoolClassId": "0f86e317-cae0-49a0-b539-f80b6f29f4b6",
        "schoolClass": null
    },
    {
        "id": "835e1f5b-9092-4ec8-9a73-b4e5ed076091",
        "name": "Bruce",
        "score": 666,
        "schoolClassId": "0f86e317-cae0-49a0-b539-f80b6f29f4b6",
        "schoolClass": null
    },
    {
        "id": "3920cce5-53da-4111-8ebd-d38a0db2e2fd",
        "name": "Caio Julio Cesar",
        "score": 987,
        "schoolClassId": "0f86e317-cae0-49a0-b539-f80b6f29f4b6",
        "schoolClass": null
    }
]
```

### Example 2
**GET:**```https://localhost:44395/Student?$select=name,score&$orderby=score```

**Result:**
```
[
    {
        "Name": "Mario Bros Da Silva",
        "Score": 555
    },
    {
        "Name": "João Felipe",
        "Score": 637
    },
    {
        "Name": "Bruce",
        "Score": 666
    },
    {
        "Name": "Solid Snake",
        "Score": 830
    },
    {
        "Name": "Caio Julio Cesar",
        "Score": 987
    }
]
```
