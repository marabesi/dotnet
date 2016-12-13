using System;
using System.Collections.Generic;
using System.Text;

namespace Fiap.PlataformaNet.Exercicio04Lib
{
    public class ContaCorrente
    {
        public Cliente Correntista { get; set; }

        public int Banco { get; set; }

        public int Agencia { get; set; }

        public int NumeroConta { get; set; }

        public double Saldo { get; protected set; }

        public Queue<Movimentacao> Movimentos { get; set; }

        public ContaCorrente()
        {
            Movimentos = new Queue<Movimentacao>();
        }

        public virtual void EfetuarSaque(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();
            }

            if (valor > Saldo)
            {
                throw new InvalidOperationException();
            }

            Saldo -= valor;
        }

        public virtual void EfetuarDeposito(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();
            }

            Saldo += valor;
        }

        public override string ToString()
        {
            return this.Agencia + " - " + this.Banco;
        }

        public string ExibirExtrato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("\nBanco")
                .Append(this.Banco)
                .Append("\nAgencia")
                .Append(this.Agencia)
                .Append("\nConta")
                .Append(this.NumeroConta);

            foreach(var item in Movimentos)
            {
                sb.Append("\nMov - ").Append(item);
            }

            sb.Append("\n\nSaldo")
                .Append(this.Saldo);

            return sb.ToString();
        }
    }
}
