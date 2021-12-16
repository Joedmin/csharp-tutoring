using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching
{
	class Cat : Mammal, IPet
	{
		public string Race { get; }

		public string Owner { get; set; }


		public Cat(string name, string color, int age, string food, string race) : base(name, color, age, food)
		{
			Race = race;
		}

		public void Cuddle()
		{
			throw new ArgumentException("Fuck you");
		}

		public void Eat()
		{
			Console.WriteLine("*eating*");
		}

		public void Sleep()
		{
			for (var i = 0; i < 999; i++)
			{
				Console.WriteLine("ZzZzZ");
			}
		}
	}
}
