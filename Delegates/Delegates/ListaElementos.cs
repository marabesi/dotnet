using System;
using System.Collections.Generic;

namespace Delegates
{
	public class ListaElementos<T>
	{
		private T[] elementos;

		public void AtribuirArray(T[] array)
		{
			this.elementos = array;
		}

		public IEnumerable<T> Listar()
		{
			return elementos;
		}

		public T Buscar(Verificacao<T> validacao)
		{
			foreach (var item in elementos)
			{
				if (validacao(item))
				{
					return item;
				}
			}

			return default(T);
		}

		public T[] BuscaSubLista(BuscaLista<T> lista, T item, T[] colecao) {
			T[] elementos = lista(item, colecao);

			return elementos;
		}
	}
}
