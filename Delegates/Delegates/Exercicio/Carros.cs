using System;
namespace Delegates
{
	public class Carros<T>
	{
		public T[] Find(Exercicio.BuscaLista<T> verifica, T elemento, T[] lista)
		{
			return verifica(elemento, lista);
		}
	}
}
