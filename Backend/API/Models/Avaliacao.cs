using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Avaliacao
    {
        public int Id { get; set; } // Chave primária, auto incrementar
        public int Nota { get; set; } // 1 a 5
        public string? Comentario { get; set; } // Máximo: 1000 caracteres
        public DateTime DataAvaliacao { get; set; } = DateTime.Now;
    }
}