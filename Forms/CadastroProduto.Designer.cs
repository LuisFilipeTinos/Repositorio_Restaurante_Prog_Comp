namespace Restaurante.Forms
{
    partial class CadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroProduto));
            labelNome = new Label();
            nomeTextBox = new TextBox();
            label1 = new Label();
            labelCodigo = new Label();
            codTextBox = new TextBox();
            labelCategoria = new Label();
            categoriaComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            buttonCadastroProduto = new Button();
            custoNumericUpDown = new NumericUpDown();
            vendaNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)custoNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vendaNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNome.AutoSize = true;
            labelNome.Location = new Point(13, 126);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(65, 25);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nomeTextBox.Location = new Point(101, 126);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(776, 31);
            nomeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15F);
            label1.Location = new Point(287, 35);
            label1.Name = "label1";
            label1.Size = new Size(320, 34);
            label1.TabIndex = 2;
            label1.Text = "Cadastro de Produto";
            // 
            // labelCodigo
            // 
            labelCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(13, 176);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(75, 25);
            labelCodigo.TabIndex = 3;
            labelCodigo.Text = "Código:";
            // 
            // codTextBox
            // 
            codTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            codTextBox.Location = new Point(101, 176);
            codTextBox.Name = "codTextBox";
            codTextBox.Size = new Size(247, 31);
            codTextBox.TabIndex = 4;
            // 
            // labelCategoria
            // 
            labelCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(368, 176);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(92, 25);
            labelCategoria.TabIndex = 5;
            labelCategoria.Text = "Categoria:";
            // 
            // categoriaComboBox
            // 
            categoriaComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriaComboBox.FormattingEnabled = true;
            categoriaComboBox.Items.AddRange(new object[] { "Salgados", "Doces", "Refeições", "Lanches", "Bebidas" });
            categoriaComboBox.Location = new Point(466, 174);
            categoriaComboBox.Name = "categoriaComboBox";
            categoriaComboBox.Size = new Size(411, 33);
            categoriaComboBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(19, 232);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 7;
            label2.Text = "Preço de Custo: ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(453, 232);
            label3.Name = "label3";
            label3.Size = new Size(144, 25);
            label3.TabIndex = 9;
            label3.Text = "Preço de Venda: ";
            // 
            // buttonCadastroProduto
            // 
            buttonCadastroProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastroProduto.Location = new Point(19, 310);
            buttonCadastroProduto.Name = "buttonCadastroProduto";
            buttonCadastroProduto.Size = new Size(858, 53);
            buttonCadastroProduto.TabIndex = 11;
            buttonCadastroProduto.Text = "Cadastrar";
            buttonCadastroProduto.UseVisualStyleBackColor = true;
            buttonCadastroProduto.Click += BtnCadastroProduto_Click;
            // 
            // custoNumericUpDown
            // 
            custoNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            custoNumericUpDown.DecimalPlaces = 2;
            custoNumericUpDown.Location = new Point(162, 233);
            custoNumericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            custoNumericUpDown.Name = "custoNumericUpDown";
            custoNumericUpDown.Size = new Size(274, 31);
            custoNumericUpDown.TabIndex = 12;
            custoNumericUpDown.ThousandsSeparator = true;
            // 
            // vendaNumericUpDown
            // 
            vendaNumericUpDown.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vendaNumericUpDown.DecimalPlaces = 2;
            vendaNumericUpDown.Location = new Point(599, 230);
            vendaNumericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            vendaNumericUpDown.Name = "vendaNumericUpDown";
            vendaNumericUpDown.Size = new Size(278, 31);
            vendaNumericUpDown.TabIndex = 13;
            vendaNumericUpDown.ThousandsSeparator = true;
            // 
            // CadastroProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 418);
            Controls.Add(vendaNumericUpDown);
            Controls.Add(custoNumericUpDown);
            Controls.Add(buttonCadastroProduto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(categoriaComboBox);
            Controls.Add(labelCategoria);
            Controls.Add(codTextBox);
            Controls.Add(labelCodigo);
            Controls.Add(label1);
            Controls.Add(nomeTextBox);
            Controls.Add(labelNome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CadastroProduto";
            Text = "Cadastro Produto";
            ((System.ComponentModel.ISupportInitialize)custoNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)vendaNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private TextBox nomeTextBox;
        private Label label1;
        private Label labelCodigo;
        private TextBox codTextBox;
        private Label labelCategoria;
        private ComboBox categoriaComboBox;
        private Label label2;
        private Label label3;
        private Button buttonCadastroProduto;
        private NumericUpDown custoNumericUpDown;
        private NumericUpDown vendaNumericUpDown;
    }
}