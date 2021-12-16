using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teaching
{
	class Mammal : Animal
	{
		public string TypeOfFood { get; }

		public Mammal(string name, string color, int age, string food) : base(name, color, age)
		{
			TypeOfFood = food;
		}
	}
}
