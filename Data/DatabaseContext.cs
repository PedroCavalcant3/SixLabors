using Microsoft.EntityFrameworkCore;

namespace App.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Imagem>().ToTable("Imagem");
        modelBuilder.Entity<Galeria>().ToTable("Galeria");
    }

    public DbSet<Imagem> Imagens { get; set; }
    public DbSet<Galeria> Galerias { get; set; }
}