using Api_Filmes_Senai.Domains;
using Microsoft.EntityFrameworkCore;

public class Filmes_Context : DbContext
{
    public Filmes_Context() { }

    public Filmes_Context(DbContextOptions<Filmes_Context> options) : base(options)
    {
    }

    public DbSet<Genero> Genero { get; set; }
    public DbSet<Filme> Filmes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=NOTE41-S28\\SQLEXPRESS;Database=Filmes;User ID=sa;Password=Senai@134;TrustServerCertificate=true");
        }
    }
}
