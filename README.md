## Pour init un projet C# il faut faire : 
```bash
dotnet new console -n <leNomDuProjet>
cd <leNomDuProjet>
```
ou pour créer un projet backend :
```bash
dotnet new webapi -n <leNomDuProjet>
```
Et voila, ça va créer un dossier avec des fichiers nécéssaire au développement en C#, pour lancer un fichier donc l'équivalent du node <nomDuFichier> il faut faire 
```bash
dotnet run
```
et ça va lancer le code du fichier Program.cs

## CONNECTER POSTGRESQL A C#

Installer les packages NuGet :
```bash
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Swashbuckle.AspNetCore
```

Mettre la connexion dans appsettings.json :
```js
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=maBDD;Username=monUser;Password=monMotDePasse"
  }
}
```

Crée un ApplicationDbContext.cs dans un dossier Data/ :
```js
using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Tu déclareras ici tes tables, ex :
        // public DbSet<User> Users { get; set; }
    }
}
```

Ajouter dans Program.cs le ligne avec un commentaire au dessus

pour utiliser l'équivalent de sequelize :
```bash
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Pour créer un dossier test en c# il faut faire a l'extérieur du backend la commande :
```bash
dotnet new xunit -n Backend.Tests
```
ça va créer un projet test et pour lancer le test il suffit de faire dotnet test