using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Avaliacao
    {
        public int Id { get; set; } // Chave primária, auto incrementar
        public double Nota { get; set; } // 1 a 5
        public string? Comentario { get; set; } // Máximo: 1000 caracteres
        public DateTime DataAvaliacao { get; set; } = DateTime.Now;

        public int FilmeSerieId { get; set; } // Chave estrangeira
        public FilmeSerie? FilmeSerie { get; set; } // Relação 1 Avaliação / 1 FilmeSerie

        public int UsuarioId { get; set; } // Chave estrangeira
        public Usuario? Usuario { get; set; } // Relação 1 Avaliação / 1 Usuário
    }
}