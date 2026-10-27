using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Classes
{
    public class ProdutoVenda
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Subtotal => Quantidade * PrecoUnitario;
    }
}
