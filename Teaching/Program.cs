using System;

namespace Teaching
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
			var d = new int[] { 1, 2, 3, 4, 5 };

			c[3] = 9;

			foreach (var prvek in c)
			{
				Console.Write(prvek + ", ");
			}
			Console.WriteLine();

			Console.WriteLine(string.Join(", ", c));

			Array.Sort(c);

			Console.WriteLine(string.Join(", ", c));

			var m = new Mammal("Alex", "yellow", 5, "meat");
			Console.WriteLine(m.Age);
			m.Age = 7;
			Console.WriteLine(m.Age);
			m.Rename("Tonda");
			Console.WriteLine(m.Name);

			var dog = new Dog("Rufus", "gold", 3, "meat", "retirever")
			{
				CollarColor = "blue",
				LeadColor = "blue",
			};

			Console.WriteLine(dog.LeadColor);

			Tool.MakeBoom();
			var v = Tool.Multiply(2, 3);
			Console.WriteLine(v);
			var g = Math.Pow(3, 2);
			Console.WriteLine(g);

			Console.WriteLine(Tool.TwoDividedByThree);


			dog.DoTrick();
			dog.Sleep();
			//dog.Cuddle();

			Cat cat = new("Rosmarie", "black", 6, "fish", "bengal");

			cat.Eat();
			cat.Cuddle();
			cat.Sleep();

			for (var i = 0; i < 3; i++)
			{
				var r = Tool.GetRandomNuber();

				if (r is not null)
				{
					Console.WriteLine(r);
				}
				else
				{
					Console.WriteLine("smula");
				}
			}

			Console.ReadKey(true);
		}
	}
}
