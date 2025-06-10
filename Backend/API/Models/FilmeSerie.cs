using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class FilmeSerie
    {
        public int Id { get; set; } // Chave primária, auto incrementar
        public string? Titulo { get; set; } // Máximo: 100 caracteres
        public string? Diretor { get; set; } // Máximo: 50 caracteres
        public int Ano { get; set; }
    }
}