using System;

namespace Zaklady
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = 3;

			switch (a)
			{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
					Console.WriteLine("jupi");
					break;
				default:
					Console.WriteLine("smula");
					break;
			}

			if (a == 0 || a == 1 || a == 2 || a == 3)
			{
			}
			else
			{

			}

			while (a < 3)
			{
				Console.WriteLine("lol");
			}

			do
			{
				Console.WriteLine("lolisek");
			} while (a < 3);

			var b = new int[] { 1, 2, 3, 4 };
			for (var i = 0; i < b.Length; i++)
			{
				if (i == 2)
				{
					continue;
				}
				if (i == 3)
				{
					break;
				}
				Console.WriteLine(b[i]);
			}

			// for i in [1,2,3,4]:
			foreach (var prvek in b)
			{
				Console.WriteLine(prvek);
			}

			var c = new int[8] { 1, 2, 3, 4, 5, 0, 0, 0 };

			c[3] = 9;

			foreach (var prvek in c)
			{
				Console.Write(prvek + ", ");
			}
			Console.WriteLine();

			Console.WriteLine(string.Join(", ", c));

			Array.Sort(c);

			Console.WriteLine(string.Join(", ", c));
		}
	}
}
