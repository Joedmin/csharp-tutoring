using System;

namespace Kolekce
{
	static class Tool
	{
		public static string Material = "steel";
		public static double TwoDividedByThree => (double)2 / 3;

		public static void MakeBoom()
		{
			Console.WriteLine("Boom");
		}

		public static double Multiply(double a, double b) => a * b;

		public static int? GetRandomNuber()
		{
			var r = new Random().Next(3, 6);
			if (r == 4)
			{
				return null;
			}
			return r;
		}
	}
}
