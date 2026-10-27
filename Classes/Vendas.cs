using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Classes
{
    public class Vendas
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string? FormaPagamento { get; set; }
        public int Parcelas { get; set; } = 1;
        public decimal Total { get; set; }
        public List<ProdutoVenda>? ProdutosVenda { get; set; } = new List<ProdutoVenda>();
    }
}
