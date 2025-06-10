using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Usuario
    {
        public int Id { get; set; } // Chave primária, auto incrementar
        public string? Nome { get; set; } // Máximo: 50 caracteres
        public string? Email { get; set; } // Máximo: 50 caracteres
    }
}