using System;
using System.Collections.Generic;

namespace Delegates
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string[] cursos = { "android", "c#", "cobol", "PHP", "Java" };

			ListaElementos<string> le = new ListaElementos<string>();
			le.AtribuirArray(cursos);

			string busca = le.Buscar(s => s.StartsWith("c"));

			Console.WriteLine(busca);

			List<string> cusros2 = new List<string> { "android", "c#", "cobol", "PHP", "Java" };
			string busca2 = cusros2.Find(s => s.StartsWith("a"));

			Console.WriteLine(busca2);
		}
	}
}
