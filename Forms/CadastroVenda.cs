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
    public partial class CadastroVenda : Form
    {
        CultureInfo brasil = new CultureInfo("pt-BR");
        public CadastroVenda()
        {
            InitializeComponent();

            clienteComboBox.Items.Clear();

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;

            foreach (Cliente cliente in Banco.Clientes)
            {
                clienteComboBox.Items.Add(cliente);
            }

            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colMenos",
                HeaderText = "",
                Text = "–",
                UseColumnTextForButtonValue = true, // todas as células mostram o mesmo texto
                Width = 40,
                FlatStyle = FlatStyle.Flat
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colQtd",
                HeaderText = "Qtd",
                ReadOnly = true,   // só muda pelos botões
                Width = 50
            });

            dataGridView1.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colMais",
                HeaderText = "",
                Text = "+",
                UseColumnTextForButtonValue = true,
                Width = 40,
                FlatStyle = FlatStyle.Flat
            });

            // centraliza a quantidade
            dataGridView1.Columns["colQtd"]?.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Rows.Clear();

            foreach (Produto produto in Banco.Produtos)
            {
                dataGridView1.Rows.Add(
                        produto.Codigo,
                        produto.Nome ?? "",
                        produto.Categoria ?? "",
                        produto.PrecoCusto,
                        produto.PrecoVenda,
                        null,
                        0,
                        null
                );
            }
        }

        private void DataGridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return; // clicou no cabeçalho

            string coluna = dataGridView1.Columns[e.ColumnIndex].Name;

            if (coluna != "colMais" && coluna != "colMenos")
                return;

            DataGridViewCell celulaQtd = dataGridView1.Rows[e.RowIndex].Cells["colQtd"];
            int qtd = Convert.ToInt32(celulaQtd.Value ?? 0);

            if (coluna == "colMais")
                qtd++;

            else if (qtd > 0)   // não deixa ficar negativo
                qtd--;

            celulaQtd.Value = qtd;
            AtualizarSelecionados();
        }

        private void AtualizarSelecionados()
        {
            listBox1.Items.Clear();
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int qtd = Convert.ToInt32(row.Cells["colQtd"].Value ?? 0);

                if (qtd == 0)
                    continue;

                string nome = row.Cells["Nome"]?.Value?.ToString() ?? "";
                decimal preco = Convert.ToDecimal(row.Cells["PrecoVenda"].Value);
                decimal subtotal = qtd * preco;
                total += subtotal;

                listBox1.Items.Add($"{qtd}x {nome} - {subtotal:C}");
            }

            totalLabel.Text = $"Total: {total:C}";
        }

        private void Pagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pagamentoComboBox.Text == "Cartão")
            {
                parcelasLabel.Enabled = true;
                parcelasComboBox.Enabled = true;
            }
            else
            {
                parcelasLabel.Enabled = false;
                parcelasComboBox.Enabled = false;
                parcelasComboBox.SelectedIndex = -1;
            }
        }

        private void ButtonCadastroProduto_Click(object sender, EventArgs e)
        {
            // 1. Validações
            if (clienteComboBox.SelectedItem is not Cliente cliente)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            if (pagamentoComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione a forma de pagamento.");
                return;
            }

            // 2. Monta a venda
            Vendas venda = new Vendas
            {
                Id = Banco.Vendas.Count == 0 ? 1 : Banco.Vendas.Max(v => v.Id) + 1,
                IdCliente = cliente.Id,
                FormaPagamento = pagamentoComboBox.Text,
                Parcelas = 1
            };

            if (pagamentoComboBox.Text == "Cartão" && parcelasComboBox.SelectedIndex != -1)
            {
                // "3x" -> 3
                venda.Parcelas = int.Parse(parcelasComboBox.Text.Replace("x", ""));
            }

            // 3. Percorre o grid e cria um ProdutoVenda para cada item com quantidade
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int qtd = Convert.ToInt32(row.Cells["colQtd"].Value ?? 0);
                if (qtd == 0)
                    continue;

                venda?.ProdutosVenda?.Add(new ProdutoVenda
                {
                    Id = venda.ProdutosVenda.Count + 1,
                    Codigo = Convert.ToInt32(row.Cells["Codigo"].Value),
                    Quantidade = qtd,
                    PrecoUnitario = Convert.ToDecimal(row.Cells["PrecoVenda"].Value)
                });
            }

            if (venda?.ProdutosVenda?.Count == 0)
            {
                MessageBox.Show("Adicione pelo menos um produto.");
                return;
            }

            venda?.Total = venda.ProdutosVenda.Sum(p => p.Subtotal);

            // 4. Salva
            Banco.Vendas.Add(venda);

            MessageBox.Show($"Venda {venda.Id} finalizada! Total: {venda.Total:C}");
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            clienteComboBox.SelectedIndex = -1;
            pagamentoComboBox.SelectedIndex = -1;
            parcelasComboBox.SelectedIndex = -1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
                row.Cells["colQtd"].Value = 0;

            AtualizarSelecionados(); // limpa a ListBox e zera o Total
        }
    }
}
