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
    public partial class ListagemCliente : Form
    {
        public ListagemCliente()
        {
            InitializeComponent();
        }

        public void ListagemClientes_Load(object sender, EventArgs e) 
        {
            ListarTabelaClientes();
        }

        public void ListarTabelaClientes()
        {
            dataGridView1.Rows.Clear();

            foreach (Cliente cliente in Banco.Clientes)
            {
                dataGridView1.Rows.Add(
                        cliente.Nome ?? "",
                        cliente.Cpf ?? "",
                        cliente.DataNascimento,
                        cliente.Endereco ?? ""
                );
            }
        }
    }
}
