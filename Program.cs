using Microsoft.EntityFrameworkCore;
using ProjetCrud;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("Default"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Default"))));

builder.Services.AddControllers();

var app = builder.Build();

// Middleware pour les fichiers statiques
app.UseDefaultFiles(); // Sert index.html par d�faut
app.UseStaticFiles();

app.UseAuthorization();
app.MapControllers();

app.Run();