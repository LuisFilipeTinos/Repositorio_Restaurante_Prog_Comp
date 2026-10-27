using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Cpf { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string? Endereco { get; set; }

        public override string ToString()
        {
            return Nome ?? "";
        }
    }
}
