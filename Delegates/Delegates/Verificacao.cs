using System;
namespace Delegates
{
	public delegate bool Verificacao<T>(T obj);

	public delegate T[] BuscaLista<T>(T elemento, T[] lista);
}
