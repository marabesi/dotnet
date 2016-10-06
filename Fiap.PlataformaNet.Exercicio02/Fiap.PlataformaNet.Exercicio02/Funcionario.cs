using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Exercicio02
{
    public class Funcionario
    {

        //props
        public double Irpf { get; private set; }
        public double Inss { get; private set; }
        public double SalarioLiquido { get; private set; }
        
        //atributo
        private double _salarioBruto;
        public double SalarioBruto {
            get {
                return _salarioBruto;
            }
            set {
                _salarioBruto = value;
                Inss = CalcularInss();
                Irpf = CalcularImpostoRenda();
                SalarioLiquido = _salarioBruto - Irpf - Inss;
            }
        }

        //Métodos
        private double CalcularImpostoRenda()
        {
            double[] taxas = { 0,7.5,15,22.5,27.5};
            double[] valores = { 0, 1499.15, 2246.75, 2995.7, 3743.19 };

            double salario = SalarioBruto - Inss; // base calculo
            double imposto = 0;

            for (int i = taxas.Length-1; i >= 0; i--)
            {
                if (SalarioBruto > valores[i])
                {
                    imposto += (SalarioBruto - valores[i]) * taxas[i] / 100;
                    salario = valores[i];
                }
            }

            return imposto;
        }

        private double CalcularInss()
        {
            return SalarioBruto * 0.1;
        }

        public string MostrarDados()
        {
            return "dsadsa";
        }

    }
}
