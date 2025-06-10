using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Models
{
    public class AppDataContext : DbContext
    {
        public DbSet<FilmeSerie> FilmeSerie { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=AvaliacaoFilmesSeries.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração das relações
            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.FilmeSerie)
                .WithMany(f => f.Avaliacoes)
                .HasForeignKey(a => a.FilmeSerieId);

            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.Usuario)
                .WithMany(u => u.Avaliacoes)
                .HasForeignKey(a => a.UsuarioId);

            // Configurações adicionais para tamanho máximo de campos
            modelBuilder.Entity<FilmeSerie>()
                .Property(f => f.Titulo)
                .HasMaxLength(100);

            modelBuilder.Entity<FilmeSerie>()
                .Property(f => f.Diretor)
                .HasMaxLength(50);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Nome)
                .HasMaxLength(50);

            modelBuilder.Entity<Usuario>()
                .Property(u => u.Email)
                .HasMaxLength(50);

            modelBuilder.Entity<Avaliacao>()
                .Property(a => a.Comentario)
                .HasMaxLength(1000);
        }
    }
}