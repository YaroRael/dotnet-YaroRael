using Microsoft.EntityFrameworkCore;
using ProjetCrud.Models;

namespace ProjetCrud;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Client> Clients { get; set; }
}