using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Exercicio04Lib
{
    public class Movimentacao
    {
        ContaCorrente Conta { get; set; }

        public DateTime Data { get; set; }

        public string Historico { get; set; }

        public double Valor { get; set; }
        
        public Movimentacao() { }

        public Movimentacao(ContaCorrente Conta, DateTime Data, string Historico, double Valor)
        {
            this.Conta = Conta;
            this.Data = Data;
            this.Historico = Historico;
            this.Valor = Valor;
        }

        public override string ToString()
        {
            string linha = string.Format("{0:ddd/MM/yyyy} {1,-15} {2,15:N2}", this.Data, this.Historico, this.Valor);

            return linha;
        }
    }
}
