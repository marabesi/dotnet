namespace Fiap.PlataformaNet.Exercicio02
{
    partial class FormFolha
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
            this.label1 = new System.Windows.Forms.Label();
            this.SalarioTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.IRPFtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.INSStextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.salarioLiquidoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário:";
            // 
            // SalarioTextBox
            // 
            this.SalarioTextBox.Location = new System.Drawing.Point(112, 28);
            this.SalarioTextBox.Name = "SalarioTextBox";
            this.SalarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalarioTextBox.TabIndex = 1;
            // 
            // calcularButton
            // 
            this.calcularButton.Location = new System.Drawing.Point(112, 54);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(100, 23);
            this.calcularButton.TabIndex = 2;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = true;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // IRPFtextBox
            // 
            this.IRPFtextBox.Location = new System.Drawing.Point(112, 98);
            this.IRPFtextBox.Name = "IRPFtextBox";
            this.IRPFtextBox.Size = new System.Drawing.Size(100, 20);
            this.IRPFtextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor IRPF:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // INSStextBox
            // 
            this.INSStextBox.Location = new System.Drawing.Point(112, 124);
            this.INSStextBox.Name = "INSStextBox";
            this.INSStextBox.Size = new System.Drawing.Size(100, 20);
            this.INSStextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor INSS:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // salarioLiquidoTextBox
            // 
            this.salarioLiquidoTextBox.Location = new System.Drawing.Point(112, 150);
            this.salarioLiquidoTextBox.Name = "salarioLiquidoTextBox";
            this.salarioLiquidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.salarioLiquidoTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Salário Líquido:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormFolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 192);
            this.Controls.Add(this.salarioLiquidoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.INSStextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IRPFtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.SalarioTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FormFolha";
            this.Text = "FormFolha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SalarioTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.TextBox IRPFtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox INSStextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox salarioLiquidoTextBox;
        private System.Windows.Forms.Label label4;
    }
}

