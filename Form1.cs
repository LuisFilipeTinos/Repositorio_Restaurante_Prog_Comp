using Restaurante.Forms;

namespace Restaurante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbrirCadastroProduto_Click(object sender, EventArgs e)
        {
            CadastroProduto formCadastroProduto = new CadastroProduto();
            formCadastroProduto.ShowDialog();
        }

        private void AbrirListagemProdutos_Click(object sender, EventArgs e)
        {
            ListagemProduto formListagemProdutos = new ListagemProduto();
            formListagemProdutos.ShowDialog();
        }

        private void ClienteToolStripMeniItem_Click(object sender, EventArgs e)
        {
            CadastroCliente formCadastroCliente = new CadastroCliente();
            formCadastroCliente.ShowDialog();
        }

        private void ListagemClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListagemCliente formListagemCliente = new ListagemCliente();
            formListagemCliente.ShowDialog();
        }

        private void SobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de restaurante desenvolvido na disciplina de Programação de Computadores do curso de Engenharia da Computação",
                   "Sobre",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information
            );
        }

        private void VendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVenda formCadastroVenda = new CadastroVenda();
            formCadastroVenda.ShowDialog();
        }
    }
}
