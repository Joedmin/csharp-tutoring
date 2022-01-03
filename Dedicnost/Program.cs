using System;

namespace Dedicnost
{
	class Program
	{
		static void Main(string[] args)
		{
			ElectricGuitar guitar = new(8, 5)
			{
				Amplifier = "Fender Mustang LT25",
			};

			guitar.Recharge();

			string hodnota = guitar.ToString();
			Console.WriteLine(guitar);

			Console.WriteLine("-----");


			Console.WriteLine(guitar);

			guitar.Recharge();

			guitar.Play();
			Console.WriteLine(guitar.Amplifier);
			guitar.Play();
			guitar.Play();
			guitar.Amplifier = null;
			guitar.Play();

			guitar.Amplifier = "Fender Mustang LT25";
			guitar.Recharge();

			guitar.Play("Rip & Tear by mick Gordon");

			Console.WriteLine(guitar.Amplifier);
			Console.WriteLine(guitar.StringCount);
			Console.WriteLine(guitar.StringDurability);
			Console.WriteLine(guitar.IsCharged);

			var defaultGuitar = new ElectricGuitar();
			Console.WriteLine(defaultGuitar.Amplifier);
			Console.WriteLine(defaultGuitar.StringCount);
			Console.WriteLine(defaultGuitar.StringDurability);
			Console.WriteLine(defaultGuitar.IsCharged);

			defaultGuitar.Fall(true);

			Console.ReadKey();
		}
	}
}
