using System;

namespace Kolekce
{
	public class Animal : Creature
	{
		public string Name { get; set; }
		public string Color { get; set; }
		public int Age { get; set; }

		public Animal(string Name, string color, int age)
		{
			this.Name = Name;
			Color = color;
			Age = age;
		}

		public virtual void MakeNoise()
		{
			Console.WriteLine("Roar");
		}

		public string GetRandomString()
		{
			return "Abcd";
		}

		public override void Hunt()
		{
			Console.WriteLine("Hunting");
		}
	}
}
