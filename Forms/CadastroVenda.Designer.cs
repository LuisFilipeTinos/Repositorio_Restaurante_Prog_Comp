namespace Restaurante.Forms
{
    partial class CadastroVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroVenda));
            label1 = new Label();
            nomeLabel = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            PrecoCusto = new DataGridViewTextBoxColumn();
            PrecoVenda = new DataGridViewTextBoxColumn();
            listBox1 = new ListBox();
            label3 = new Label();
            clienteComboBox = new ComboBox();
            label4 = new Label();
            pagamentoComboBox = new ComboBox();
            parcelasLabel = new Label();
            parcelasComboBox = new ComboBox();
            buttonCadastroProduto = new Button();
            totalLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15F);
            label1.Location = new Point(643, 45);
            label1.Name = "label1";
            label1.Size = new Size(109, 34);
            label1.TabIndex = 7;
            label1.Text = "Venda";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new Point(52, 131);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new Size(69, 25);
            nomeLabel.TabIndex = 9;
            nomeLabel.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 187);
            label2.Name = "label2";
            label2.Size = new Size(154, 25);
            label2.TabIndex = 11;
            label2.Text = "Lista de Produtos:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(47, 62, 70);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(47, 62, 70);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 42;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nome, Categoria, PrecoCusto, PrecoVenda });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(47, 62, 70);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(47, 62, 70);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = SystemColors.MenuBar;
            dataGridView1.Location = new Point(58, 230);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 36;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1325, 217);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += DataGridProdutos_CellContentClick;
            // 
            // Codigo
            // 
            Codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Codigo.HeaderText = "Código";
            Codigo.MinimumWidth = 8;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nome
            // 
            Nome.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 8;
            Nome.Name = "Nome";
            Nome.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 8;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // PrecoCusto
            // 
            PrecoCusto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrecoCusto.HeaderText = "Preço Custo";
            PrecoCusto.MinimumWidth = 8;
            PrecoCusto.Name = "PrecoCusto";
            PrecoCusto.ReadOnly = true;
            // 
            // PrecoVenda
            // 
            PrecoVenda.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PrecoVenda.HeaderText = "Preço Venda";
            PrecoVenda.MinimumWidth = 8;
            PrecoVenda.Name = "PrecoVenda";
            PrecoVenda.ReadOnly = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(57, 511);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(355, 129);
            listBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 473);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 14;
            label3.Text = "Produtos Selecionados:";
            // 
            // clienteComboBox
            // 
            clienteComboBox.FormattingEnabled = true;
            clienteComboBox.Location = new Point(127, 131);
            clienteComboBox.Name = "clienteComboBox";
            clienteComboBox.Size = new Size(1256, 33);
            clienteComboBox.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 473);
            label4.Name = "label4";
            label4.Size = new Size(187, 25);
            label4.TabIndex = 16;
            label4.Text = "Forma de Pagamento:";
            // 
            // pagamentoComboBox
            // 
            pagamentoComboBox.FormattingEnabled = true;
            pagamentoComboBox.Items.AddRange(new object[] { "Dinheiro", "Cartão", "Pix", "Boleto" });
            pagamentoComboBox.Location = new Point(476, 511);
            pagamentoComboBox.Name = "pagamentoComboBox";
            pagamentoComboBox.Size = new Size(354, 33);
            pagamentoComboBox.TabIndex = 17;
            pagamentoComboBox.SelectedIndexChanged += Pagamento_SelectedIndexChanged;
            // 
            // parcelasLabel
            // 
            parcelasLabel.AutoSize = true;
            parcelasLabel.Enabled = false;
            parcelasLabel.Location = new Point(471, 568);
            parcelasLabel.Name = "parcelasLabel";
            parcelasLabel.Size = new Size(78, 25);
            parcelasLabel.TabIndex = 18;
            parcelasLabel.Text = "Parcelas:";
            // 
            // parcelasComboBox
            // 
            parcelasComboBox.Enabled = false;
            parcelasComboBox.FormattingEnabled = true;
            parcelasComboBox.Items.AddRange(new object[] { "2x", "3x", "4x", "6x", "8x", "10x", "12x" });
            parcelasComboBox.Location = new Point(476, 607);
            parcelasComboBox.Name = "parcelasComboBox";
            parcelasComboBox.Size = new Size(229, 33);
            parcelasComboBox.TabIndex = 19;
            // 
            // buttonCadastroProduto
            // 
            buttonCadastroProduto.Location = new Point(58, 703);
            buttonCadastroProduto.Name = "buttonCadastroProduto";
            buttonCadastroProduto.Size = new Size(1320, 65);
            buttonCadastroProduto.TabIndex = 22;
            buttonCadastroProduto.Text = "Finalizar Venda";
            buttonCadastroProduto.UseVisualStyleBackColor = true;
            buttonCadastroProduto.Click += ButtonCadastroProduto_Click;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(58, 658);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(53, 25);
            totalLabel.TabIndex = 23;
            totalLabel.Text = "Total:";
            // 
            // CadastroVenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 814);
            Controls.Add(totalLabel);
            Controls.Add(buttonCadastroProduto);
            Controls.Add(parcelasComboBox);
            Controls.Add(parcelasLabel);
            Controls.Add(pagamentoComboBox);
            Controls.Add(label4);
            Controls.Add(clienteComboBox);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(nomeLabel);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroVenda";
            Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label nomeLabel;
        private Label label2;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private Label label3;
        private ComboBox clienteComboBox;
        private Label label4;
        private ComboBox pagamentoComboBox;
        private Label parcelasLabel;
        private ComboBox parcelasComboBox;
        private Button buttonCadastroProduto;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn PrecoCusto;
        private DataGridViewTextBoxColumn PrecoVenda;
        private Label totalLabel;
    }
}