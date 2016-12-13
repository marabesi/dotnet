using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Exercicio04Lib
{
    public class ContaEspecial : ContaCorrente
    {
        public double Limite;

        public override void EfetuarSaque(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException();
            }

            if (valor > Saldo + Limite)
            {
                throw new InvalidOperationException();
            }

            Saldo -= valor;
        }
    }
}
