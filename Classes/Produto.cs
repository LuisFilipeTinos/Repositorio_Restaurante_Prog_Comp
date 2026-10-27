using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Classes
{
    public class Produto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Categoria { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
    }
}
