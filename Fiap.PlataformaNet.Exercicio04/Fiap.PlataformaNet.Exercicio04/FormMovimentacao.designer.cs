namespace Fiap.PlataformaNet.Exercicio04
{
    partial class FormMovimentacao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listarClientesButton = new System.Windows.Forms.Button();
            this.incluirClienteButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cpfTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listarContasButton = new System.Windows.Forms.Button();
            this.especialRadioButton = new System.Windows.Forms.RadioButton();
            this.comumRadioButton = new System.Windows.Forms.RadioButton();
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.incluirContaButton = new System.Windows.Forms.Button();
            this.limiteTextBox = new System.Windows.Forms.TextBox();
            this.limiteLabel = new System.Windows.Forms.Label();
            this.numContaTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AgenciaTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bancoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.extratoTextBox = new System.Windows.Forms.TextBox();
            this.gravarButton = new System.Windows.Forms.Button();
            this.exibirButton = new System.Windows.Forms.Button();
            this.operacaoButton = new System.Windows.Forms.Button();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.operacaoComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contaComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fecharButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listarClientesButton);
            this.groupBox1.Controls.Add(this.incluirClienteButton);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cpfTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 156);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // listarClientesButton
            // 
            this.listarClientesButton.Location = new System.Drawing.Point(189, 111);
            this.listarClientesButton.Name = "listarClientesButton";
            this.listarClientesButton.Size = new System.Drawing.Size(114, 31);
            this.listarClientesButton.TabIndex = 5;
            this.listarClientesButton.Text = "Listar Clientes";
            this.listarClientesButton.UseVisualStyleBackColor = true;
            this.listarClientesButton.Click += new System.EventHandler(this.listarClientesButton_Click);
            // 
            // incluirClienteButton
            // 
            this.incluirClienteButton.Location = new System.Drawing.Point(69, 111);
            this.incluirClienteButton.Name = "incluirClienteButton";
            this.incluirClienteButton.Size = new System.Drawing.Size(114, 31);
            this.incluirClienteButton.TabIndex = 4;
            this.incluirClienteButton.Text = "Incluir Cliente";
            this.incluirClienteButton.UseVisualStyleBackColor = true;
            this.incluirClienteButton.Click += new System.EventHandler(this.incluirClienteButton_Click);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(69, 85);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(245, 20);
            this.emailTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Email:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(69, 59);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(245, 20);
            this.nomeTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nome:";
            // 
            // cpfTextBox
            // 
            this.cpfTextBox.Location = new System.Drawing.Point(69, 33);
            this.cpfTextBox.Name = "cpfTextBox";
            this.cpfTextBox.Size = new System.Drawing.Size(136, 20);
            this.cpfTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listarContasButton);
            this.groupBox2.Controls.Add(this.especialRadioButton);
            this.groupBox2.Controls.Add(this.comumRadioButton);
            this.groupBox2.Controls.Add(this.clienteComboBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.incluirContaButton);
            this.groupBox2.Controls.Add(this.limiteTextBox);
            this.groupBox2.Controls.Add(this.limiteLabel);
            this.groupBox2.Controls.Add(this.numContaTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.AgenciaTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.bancoTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 177);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conta Corrente";
            // 
            // listarContasButton
            // 
            this.listarContasButton.Location = new System.Drawing.Point(189, 140);
            this.listarContasButton.Name = "listarContasButton";
            this.listarContasButton.Size = new System.Drawing.Size(114, 31);
            this.listarContasButton.TabIndex = 10;
            this.listarContasButton.Text = "Listar Contas";
            this.listarContasButton.UseVisualStyleBackColor = true;
            this.listarContasButton.Click += new System.EventHandler(this.listarContasButton_Click);
            // 
            // especialRadioButton
            // 
            this.especialRadioButton.AutoSize = true;
            this.especialRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.especialRadioButton.Location = new System.Drawing.Point(193, 50);
            this.especialRadioButton.Name = "especialRadioButton";
            this.especialRadioButton.Size = new System.Drawing.Size(96, 17);
            this.especialRadioButton.TabIndex = 0;
            this.especialRadioButton.TabStop = true;
            this.especialRadioButton.Text = "Conta Especial";
            this.especialRadioButton.UseVisualStyleBackColor = true;
            // 
            // comumRadioButton
            // 
            this.comumRadioButton.AutoSize = true;
            this.comumRadioButton.ForeColor = System.Drawing.Color.Blue;
            this.comumRadioButton.Location = new System.Drawing.Point(69, 50);
            this.comumRadioButton.Name = "comumRadioButton";
            this.comumRadioButton.Size = new System.Drawing.Size(91, 17);
            this.comumRadioButton.TabIndex = 13;
            this.comumRadioButton.TabStop = true;
            this.comumRadioButton.Text = "Conta Comum";
            this.comumRadioButton.UseVisualStyleBackColor = true;
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(69, 23);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(244, 21);
            this.clienteComboBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cliente:";
            // 
            // incluirContaButton
            // 
            this.incluirContaButton.Location = new System.Drawing.Point(69, 140);
            this.incluirContaButton.Name = "incluirContaButton";
            this.incluirContaButton.Size = new System.Drawing.Size(114, 31);
            this.incluirContaButton.TabIndex = 9;
            this.incluirContaButton.Text = "Incluir Conta";
            this.incluirContaButton.UseVisualStyleBackColor = true;
            this.incluirContaButton.Click += new System.EventHandler(this.incluirContaButton_Click);
            // 
            // limiteTextBox
            // 
            this.limiteTextBox.Location = new System.Drawing.Point(225, 114);
            this.limiteTextBox.Name = "limiteTextBox";
            this.limiteTextBox.Size = new System.Drawing.Size(88, 20);
            this.limiteTextBox.TabIndex = 8;
            // 
            // limiteLabel
            // 
            this.limiteLabel.AutoSize = true;
            this.limiteLabel.Location = new System.Drawing.Point(170, 117);
            this.limiteLabel.Name = "limiteLabel";
            this.limiteLabel.Size = new System.Drawing.Size(37, 13);
            this.limiteLabel.TabIndex = 7;
            this.limiteLabel.Text = "Limite:";
            // 
            // numContaTextBox
            // 
            this.numContaTextBox.Location = new System.Drawing.Point(69, 114);
            this.numContaTextBox.Name = "numContaTextBox";
            this.numContaTextBox.Size = new System.Drawing.Size(83, 20);
            this.numContaTextBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Num. Conta:";
            // 
            // AgenciaTextBox
            // 
            this.AgenciaTextBox.Location = new System.Drawing.Point(225, 88);
            this.AgenciaTextBox.Name = "AgenciaTextBox";
            this.AgenciaTextBox.Size = new System.Drawing.Size(88, 20);
            this.AgenciaTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Agência:";
            // 
            // bancoTextBox
            // 
            this.bancoTextBox.Location = new System.Drawing.Point(69, 88);
            this.bancoTextBox.Name = "bancoTextBox";
            this.bancoTextBox.Size = new System.Drawing.Size(83, 20);
            this.bancoTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Banco:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.extratoTextBox);
            this.groupBox3.Controls.Add(this.gravarButton);
            this.groupBox3.Controls.Add(this.exibirButton);
            this.groupBox3.Controls.Add(this.operacaoButton);
            this.groupBox3.Controls.Add(this.valorTextBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.operacaoComboBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.contaComboBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(338, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 339);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movimentação:";
            // 
            // extratoTextBox
            // 
            this.extratoTextBox.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extratoTextBox.Location = new System.Drawing.Point(25, 145);
            this.extratoTextBox.Multiline = true;
            this.extratoTextBox.Name = "extratoTextBox";
            this.extratoTextBox.Size = new System.Drawing.Size(400, 179);
            this.extratoTextBox.TabIndex = 5;
            // 
            // gravarButton
            // 
            this.gravarButton.Location = new System.Drawing.Point(312, 99);
            this.gravarButton.Name = "gravarButton";
            this.gravarButton.Size = new System.Drawing.Size(114, 31);
            this.gravarButton.TabIndex = 4;
            this.gravarButton.Text = "Gravar Extrato";
            this.gravarButton.UseVisualStyleBackColor = true;
            // 
            // exibirButton
            // 
            this.exibirButton.Location = new System.Drawing.Point(192, 99);
            this.exibirButton.Name = "exibirButton";
            this.exibirButton.Size = new System.Drawing.Size(114, 31);
            this.exibirButton.TabIndex = 3;
            this.exibirButton.Text = "Exibir Extrato";
            this.exibirButton.UseVisualStyleBackColor = true;
            // 
            // operacaoButton
            // 
            this.operacaoButton.Location = new System.Drawing.Point(72, 99);
            this.operacaoButton.Name = "operacaoButton";
            this.operacaoButton.Size = new System.Drawing.Size(114, 31);
            this.operacaoButton.TabIndex = 2;
            this.operacaoButton.Text = "Executar Operação";
            this.operacaoButton.UseVisualStyleBackColor = true;
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(72, 73);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(83, 20);
            this.valorTextBox.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Valor:";
            // 
            // operacaoComboBox
            // 
            this.operacaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operacaoComboBox.FormattingEnabled = true;
            this.operacaoComboBox.Location = new System.Drawing.Point(72, 46);
            this.operacaoComboBox.Name = "operacaoComboBox";
            this.operacaoComboBox.Size = new System.Drawing.Size(161, 21);
            this.operacaoComboBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Operação:";
            // 
            // contaComboBox
            // 
            this.contaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contaComboBox.FormattingEnabled = true;
            this.contaComboBox.Location = new System.Drawing.Point(72, 19);
            this.contaComboBox.Name = "contaComboBox";
            this.contaComboBox.Size = new System.Drawing.Size(161, 21);
            this.contaComboBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Conta:";
            // 
            // fecharButton
            // 
            this.fecharButton.Location = new System.Drawing.Point(661, 365);
            this.fecharButton.Name = "fecharButton";
            this.fecharButton.Size = new System.Drawing.Size(114, 31);
            this.fecharButton.TabIndex = 3;
            this.fecharButton.Text = "Fechar";
            this.fecharButton.UseVisualStyleBackColor = true;
            // 
            // FormMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 408);
            this.Controls.Add(this.fecharButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMovimentacao";
            this.Text = "Movimentação Bancária";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cpfTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button incluirClienteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button incluirContaButton;
        private System.Windows.Forms.TextBox limiteTextBox;
        private System.Windows.Forms.Label limiteLabel;
        private System.Windows.Forms.TextBox numContaTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AgenciaTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bancoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox extratoTextBox;
        private System.Windows.Forms.Button gravarButton;
        private System.Windows.Forms.Button exibirButton;
        private System.Windows.Forms.Button operacaoButton;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox operacaoComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox contaComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button fecharButton;
        private System.Windows.Forms.RadioButton especialRadioButton;
        private System.Windows.Forms.RadioButton comumRadioButton;
        private System.Windows.Forms.Button listarClientesButton;
        private System.Windows.Forms.Button listarContasButton;
    }
}

