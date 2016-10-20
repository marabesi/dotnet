using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiap.PlataformaNet.Exercicio05
{
    public partial class Form1 : Form
    {
        public delegate double Calculadora(double a, double b);
        public delegate string Operacao(DateTime data);
        public delegate void Mensagem();
        public delegate string Resultado<T>(T obb);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // referência de método
            Calculadora calc1 = new Calculadora(Somar);
            MessageBox.Show("calc1 (2, 3) = " + calc1(2, 3));

            // usando método anônimo
            Calculadora calc2 = delegate (double x, double y)
            {
                return x + y;
            };
            MessageBox.Show("calc2 (2, 3) = " + calc2(2, 3));

            Calculadora calc3 = (x, y) => x * y;
            MessageBox.Show("calc3 (2, 3) = " + calc3(2, 3));

            Calculadora calc4 = (x, y) =>
            {
                x += 10;
                y += 10;

                return x * y;
            };
            MessageBox.Show("calc4 (2, 3) = " + calc3(2, 3));
        }

        private double Somar(double a, double b)
        {
            return a + b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operacao op = d => d.ToLongDateString();
            MessageBox.Show("op(DateTime.Now) = " + op(DateTime.Now));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mensagem msg = () => MessageBox.Show("Mensagem vazia");
            msg();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Resultado<int> result1 = x => x.ToString("c");

            MessageBox.Show("result(100) = " + result1(100));

            Resultado<List<string>> result2 = x => (x.Count == 0 ? "nenhum" : x[0]);

            string s = result2(new List<string> { "Um", "Dois" });

            MessageBox.Show(s);
        }
    }
}
