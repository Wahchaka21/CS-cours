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

Ajouter dans Program.cs le :
```js
using Backend.Data;
using Microsoft.EntityFrameworkCore;

//connexion à PostgreSQL 
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//pour un server propre ces 3 lignes =>
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//équivalent du cors en node.js =>
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

builder.Services.AddOpenApi();

var app = builder.Build();

//vérifie la co au démarrage pour la bdd =>

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    try
    {
        db.Database.OpenConnection();
        db.Database.CloseConnection();
        Console.WriteLine("Base de données connectée.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur lors de la connexion à la base de données : {ex.Message}");
    }
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    //rajouter ces deux
    app.UseSwagger();
    app.UseSwaggerUI();
}

//à mettre ces trois lignes également
app.UseCors();
app.UseAuthorization();
app.MapControllers();

app.UseHttpsRedirection();
```

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