using System;

namespace Kolekce
{
	public class Cat : Mammal, IPet
	{
		public string Race { get; }

		public string Owner { get; set; }

		public Cat() : base("default", "default", -1, "default")
		{
		}

		public Cat(string name, string color, int age, string food, string race) : base(name, color, age, food)
		{
			Race = race;
		}

		public override void MakeNoise()
		{
			Console.WriteLine("Meow");
		}

		public void Cuddle()
		{
			//throw new ArgumentException("Fuck you");
		}

		public override void Eat()
		{
			Console.WriteLine("*eating*");
		}

		public void Sleep()
		{
			for (var i = 0; i < 5; i++)
			{
				Console.WriteLine("ZzZzZ");
			}
		}

		public override string ToString()
		{
			return $"Cat {Name}";
		}
	}
}
