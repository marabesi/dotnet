using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.PlataformaNet.Introducao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plataforma .NET");

            string curso = "MBA dispositivos móveis";
            int meses = 12;
            double mensalidade = 10;

            String aluno = "Matheus Marabesi";

            Console.WriteLine("Curso " + curso);
            Console.WriteLine("Duração " + meses);
            Console.WriteLine("Mensalidade " + mensalidade);
            Console.WriteLine("Aluno " + aluno);
        }
    }
}
