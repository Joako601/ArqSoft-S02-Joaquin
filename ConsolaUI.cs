namespace Ahorcado
{
	public class ConsolaUI
	{
		private readonly MotorAhorcado _motor;

		public ConsolaUI(MotorAhorcado motor)
		{
			_motor = motor;
		}

		public void MostrarTablero()
		{
			Console.Clear();
			MostrarAhorcado();
			Console.WriteLine($"Intentos restantes: {_motor.IntentosRestantes}");
			Console.WriteLine($"Letras usadas: {string.Join(", ", _motor.LetrasUsadas)}");

			if (_motor.IntentosRestantes <= 3)
			{
				Console.WriteLine($"\n💡 PISTA: La palabra empieza con '{_motor.PalabraSecreta[0]}'");
			}

			Console.Write("\nPalabra: ");
			foreach (char c in _motor.PalabraSecreta)
				Console.Write(_motor.LetrasUsadas.Contains(c) ? c : '_');
			Console.WriteLine();
		}

		public char PedirLetra()
		{
			while (true)
			{
				Console.Write("\nIngresa una letra: ");
				string entrada = Console.ReadLine();

				if (!string.IsNullOrEmpty(entrada))
				{
					return char.ToLower(entrada[0]);
				}

				Console.WriteLine("⚠️ No ingresaste nada. Por favor, escribe una letra.");
			}
		}

		public void MostrarMensaje(string mensaje) => Console.WriteLine(mensaje);

		public bool PreguntarOtraVez()
		{
			Console.Write("\n¿Jugar otra vez? (s/n): ");
			return Console.ReadLine()?.ToLower() == "s";
		}

		private void MostrarAhorcado()
		{
			string[] etapas = new string[]
			{
				" -----\n | |\n |\n |\n |\n |\n=========",
				" -----\n | |\n O |\n |\n |\n |\n=========",
				" -----\n | |\n O |\n | |\n |\n |\n=========",
				" -----\n | |\n O |\n/| |\n |\n |\n=========",
				" -----\n | |\n O |\n/|\\ |\n |\n |\n=========",
				" -----\n | |\n O |\n/|\\ |\n/ |\n |\n=========",
				" -----\n | |\n O |\n/|\\ |\n/ \\ |\n |\n========="
			};

			int indice = 6 - _motor.IntentosRestantes;
			if (indice < 0) indice = 0;
			if (indice > 6) indice = 6;

			Console.WriteLine(etapas[indice]);
		}
	}
}