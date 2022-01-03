using System;

namespace Kolekce
{
	public class Dog : Mammal, IPet
	{
		public string CollarColor { get; set; } = "black";
		public string LeadColor { get; set; }
		public string Race { get; }
		public string Owner { get; set; }

		public Dog() : base("default", "default", -1, "default")
		{
		}

		public Dog(string name, string color, int age, string food, string race) : base(name, color, age, food)
		{
			Race = race;
		}

		public override void MakeNoise()
		{
			Console.WriteLine("Bark!");
		}

		public override void Hunt()
		{
			Console.WriteLine("The dog is hunting");
		}

		public override void Eat()
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

		public override string ToString()
		{
			return $"Pes {Name}";
		}
	}
}
