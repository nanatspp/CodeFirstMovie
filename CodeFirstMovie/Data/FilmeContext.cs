using CodeFirstMovie.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstMovie.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options) : base(options)
        {
        }

        public DbSet<Diretor> Diretores { get; set; }

        public DbSet<Filme> Filmes { get; set; }

        public DbSet<Genero> Generos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>()
                .HasOne(f => f.Diretor)
                .WithMany(d => d.Filmes)
                .HasForeignKey(f => f.DiretorId);

            modelBuilder.Entity<Filme>()
                .HasMany(f => f.Generos)
                .WithMany(g => g.Filmes);

        }
    }
}