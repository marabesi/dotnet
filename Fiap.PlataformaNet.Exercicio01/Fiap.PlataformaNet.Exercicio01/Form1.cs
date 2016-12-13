using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiap.PlataformaNet.Exercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            int valorSaque = Convert.ToInt32(valorDoSaqueTextBox.Text);
            if (valorSaque % 5 != 0)
            {
                MessageBox.Show("Valor inválido");
                return;
            }
            int n50 = 0, n20 = 0, n10 = 0, n5 = 0, sobra = 0;

            n50 = valorSaque / 50;
            sobra = valorSaque % 50;

            n20 = sobra / 20;
            sobra %= 20;

            n10 = sobra / 10;
            sobra %= 10;

            n5 = sobra / 5;
            sobra %= 5;

            cedula50TextBox.Text = n50.ToString();
            cedula20TextBox.Text = n20.ToString();
            cedula10TextBox.Text = n10.ToString();
            cedula5TextBox.Text = n5.ToString();

        }
    }
}
