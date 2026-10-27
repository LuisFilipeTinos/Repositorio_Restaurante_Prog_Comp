using Restaurante.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurante.Forms
{
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void BtnCadastroProduto_Click(object sender, EventArgs e)
        {
            Produto prod = new Produto();
            Banco.ProxProdutoId++;
            prod.Id = Banco.ProxProdutoId;
            prod.Codigo = Convert.ToInt32(codTextBox.Text);
            prod.Nome = nomeTextBox.Text;
            prod.Categoria = categoriaComboBox.SelectedItem?.ToString();
            prod.PrecoCusto = custoNumericUpDown.Value;
            prod.PrecoVenda = vendaNumericUpDown.Value;

            Banco.Produtos.Add(prod);

            MessageBox.Show("Cadastro realizado com sucesso!",
                   "Sucesso",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
            );

            codTextBox.Text = string.Empty;
            nomeTextBox.Text = string.Empty;
            custoNumericUpDown.Value = 0;
            vendaNumericUpDown.Value = 0;
        }
    }
}
