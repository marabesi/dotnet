using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiap.PlataformaNet.Exercicio04Lib;

namespace Fiap.PlataformaNet.Exercicio04Tests
{
    [TestClass]
    public class ContaCorrenteTest
    {
        [TestMethod]
        public void TestSacarValorMaiorDoQueOLimite()
        {
            ContaCorrente movimento = new ContaCorrente();
            movimento.Saldo = 1000;
        }
    }
}
