using System;
using System.Collections.Generic;

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

        public override string ToString()
        {
            return this.Agencia + " - " + this.Banco;
        }
    }
}
