namespace Restaurante.Forms
{
    partial class CadastroCliente
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
            buttonCadastroCliente = new Button();
            label2 = new Label();
            label1 = new Label();
            nomeTextBox = new TextBox();
            label4 = new Label();
            cpfMaskedTextBox = new MaskedTextBox();
            label5 = new Label();
            nascimentoDateTimePicker = new DateTimePicker();
            label3 = new Label();
            endeTextBox = new TextBox();
            SuspendLayout();
            // 
            // buttonCadastroCliente
            // 
            buttonCadastroCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCadastroCliente.Location = new Point(25, 292);
            buttonCadastroCliente.Name = "buttonCadastroCliente";
            buttonCadastroCliente.Size = new Size(858, 53);
            buttonCadastroCliente.TabIndex = 21;
            buttonCadastroCliente.Text = "Cadastrar";
            buttonCadastroCliente.UseVisualStyleBackColor = true;
            buttonCadastroCliente.Click += BtnCadastroCliente_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 185);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 19;
            label2.Text = "CPF:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 15F);
            label1.Location = new Point(293, 44);
            label1.Name = "label1";
            label1.Size = new Size(306, 34);
            label1.TabIndex = 15;
            label1.Text = "Cadastro de Cliente";
            // 
            // nomeTextBox
            // 
            nomeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nomeTextBox.Location = new Point(96, 135);
            nomeTextBox.Name = "nomeTextBox";
            nomeTextBox.Size = new Size(787, 31);
            nomeTextBox.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 138);
            label4.Name = "label4";
            label4.Size = new Size(65, 25);
            label4.TabIndex = 24;
            label4.Text = "Nome:";
            // 
            // cpfMaskedTextBox
            // 
            cpfMaskedTextBox.Location = new Point(96, 185);
            cpfMaskedTextBox.Mask = "000,000,000-00";
            cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            cpfMaskedTextBox.Size = new Size(110, 31);
            cpfMaskedTextBox.TabIndex = 25;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(229, 185);
            label5.Name = "label5";
            label5.Size = new Size(182, 25);
            label5.TabIndex = 26;
            label5.Text = "Data de Nascimento: ";
            // 
            // nascimentoDateTimePicker
            // 
            nascimentoDateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nascimentoDateTimePicker.Location = new Point(417, 185);
            nascimentoDateTimePicker.Name = "nascimentoDateTimePicker";
            nascimentoDateTimePicker.Size = new Size(466, 31);
            nascimentoDateTimePicker.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 234);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 28;
            label3.Text = "Endereço:";
            // 
            // endeTextBox
            // 
            endeTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            endeTextBox.Location = new Point(120, 234);
            endeTextBox.Name = "endeTextBox";
            endeTextBox.Size = new Size(763, 31);
            endeTextBox.TabIndex = 29;
            // 
            // CadastroCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 395);
            Controls.Add(endeTextBox);
            Controls.Add(label3);
            Controls.Add(nascimentoDateTimePicker);
            Controls.Add(label5);
            Controls.Add(cpfMaskedTextBox);
            Controls.Add(label4);
            Controls.Add(buttonCadastroCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nomeTextBox);
            MaximizeBox = false;
            Name = "CadastroCliente";
            Text = "CadastroCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown vendaNumericUpDown;
        private NumericUpDown custoNumericUpDown;
        private Button buttonCadastroCliente;
        private Label label3;
        private Label label2;
        private ComboBox categoriaComboBox;
        private Label labelCategoria;
        private TextBox codTextBox;
        private Label label1;
        private TextBox nomeTextBox;
        private Label label4;
        private MaskedTextBox cpfMaskedTextBox;
        private Label label5;
        private DateTimePicker nascimentoDateTimePicker;
        private TextBox endeTextBox;
    }
}