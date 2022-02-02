using System;

namespace Vyjimky
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				var a = int.Parse(Console.ReadLine());
				var b = int.Parse(Console.ReadLine());

				Console.WriteLine(a / b);
			}
			catch (FormatException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("Nezadali jste cislo");
			}
			catch (DivideByZeroException autobus)
			{
				Console.WriteLine(autobus.Message);
				Console.WriteLine("Nelze delit nulou");
				return;
			}
			finally
			{
				Console.WriteLine("ukonceno");
				Console.ReadKey();
			}

			Console.WriteLine("kontrola");
			Console.ReadKey();

			try
			{
				throw new ArgumentException("Smula");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}


			try
			{
				throw new LowBateryException("Apple je sracka");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Console.ReadKey();
		}
	}
}
