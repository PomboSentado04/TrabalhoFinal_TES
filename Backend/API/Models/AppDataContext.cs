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
    }
}