using Restaurante.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Restaurante.Forms
{
    public partial class ListagemProduto : Form
    {
        CultureInfo brasil = new CultureInfo("pt-BR");
        public ListagemProduto()
        {
            InitializeComponent();
        }

        private void ListagemProdutos_LOad(object sender, EventArgs e)
        {
            ListarTabelaProdutos();
        }

        public void ListarTabelaProdutos()
        {
            dataGridView1.Rows.Clear();

            foreach (Produto produto in Banco.Produtos)
            {
                dataGridView1.Rows.Add(
                        produto.Codigo,
                        produto.Nome ?? "",
                        produto.Categoria ?? "",
                        produto.PrecoCusto.ToString("C", brasil),
                        produto.PrecoVenda.ToString("C", brasil)
                );
            }
        }
    }
}
