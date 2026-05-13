using Ahorcado;

namespace Ahorcado
{
	public class PalabrasEnMemoria : IRepositorioPalabras
	{
		private readonly Dictionary<string, List<string>> _categorias = new()
		{
			{ "Programacion", new List<string> { "polimorfismo", "herencia", "interfaz", "encapsulamiento" } },
			{ "Hardware", new List<string> { "procesador", "memoria", "disco", "teclado" } }
		};

		private string _categoriaSeleccionada = "Programacion";

		
		public void SetCategoria(string categoria)
		{
			if (_categorias.ContainsKey(categoria))
			{
				_categoriaSeleccionada = categoria;
			}
		}


		public string ObtenerPalabraAleatoria()
		{
			var lista = _categorias[_categoriaSeleccionada];
			var random = new Random();
			return lista[random.Next(lista.Count)];
		}
	}
}