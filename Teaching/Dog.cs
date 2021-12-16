using System;

namespace Teaching
{
	sealed class Dog : Mammal, IPet
	{
		public string CollarColor { get; set; } = "black";
		public string LeadColor { get; set; }
		public string Race { get; }
		public string Owner { get; set; }

		public Dog(string name, string color, int age, string food, string race) : base(name, color, age, food)
		{
			Race = race;
		}

		public void Bark()
		{
			Console.WriteLine("Bark!");
		}

		public void Eat()
		{
			Console.WriteLine("*eating*");
		}

		public void DoTrick()
		{
			Console.WriteLine("*Doing trick*");
		}

		public void Sleep()
		{
			Console.WriteLine("*sleeping*");
		}

		public void Cuddle()
		{
			Console.WriteLine("*cuddling with owner*");
		}
	}
}
