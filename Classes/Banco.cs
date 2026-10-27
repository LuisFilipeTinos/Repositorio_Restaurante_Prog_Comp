using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurante.Classes
{
    public static class Banco
    {
        public static int ProxProdutoId = 0;
        public static int ProxClienteId = 0;
        public static int ProxVendaId = 0;
        public static int ProxProdutoVendaId = 0;
        public static List<Produto> Produtos { get; } = new List<Produto>();
        public static List<Cliente> Clientes { get; } = new List<Cliente>();
        public static List<Vendas> Vendas { get; } = new List<Vendas>();
        public static List<ProdutoVenda> ProdutosVendas { get; } = new List<ProdutoVenda>();

    }
}
