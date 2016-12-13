using System.Collections.Generic;

namespace Fiap.PlataformaNet.Exercicio04Lib
{
    public class Cliente
    {
        public string Cpf { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public List<ContaCorrente> Contas { get; set; }

        public Cliente() {
            this.Contas = new List<ContaCorrente>();
        }

        public Cliente(string Cpf, string Nome, string Email)
        {
            this.Cpf = Cpf;
            this.Nome = Nome;
            this.Email = Email;
            this.Contas = new List<ContaCorrente>();
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
