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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void BtnCadastroCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Banco.ProxClienteId++;
            cliente.Id = Banco.ProxClienteId;
            cliente.Nome = nomeTextBox.Text;
            cliente.Cpf = cpfMaskedTextBox.Text;
            cliente.DataNascimento = nascimentoDateTimePicker.Value;
            cliente.Endereco = endeTextBox.Text;

            Banco.Clientes.Add(cliente);

            MessageBox.Show("Cadastro realizado com sucesso!",
                   "Sucesso",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
            );

            nomeTextBox.Text = string.Empty;
            cpfMaskedTextBox.Text = string.Empty;
            nascimentoDateTimePicker.Value = DateTime.Today;
            endeTextBox.Text = string.Empty;
        }
    }
}
