using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fiap.PlataformaNet.Exercicio04Lib;

namespace Fiap.PlataformaNet.Exercicio04Tests
{
    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void TestCriarUmObjetoDoTipoClienteComConstrutorVazio()
        {
            Cliente c1 = new Cliente();
            c1.Cpf = "123123123";
            c1.Nome = "Nome test";
            c1.Email = "test@test.com";
            
            Assert.Equals("123123123", c1.Cpf);
        }
    }
}
