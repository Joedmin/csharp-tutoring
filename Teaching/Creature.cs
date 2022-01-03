using System;

namespace Kolekce
{
	public abstract class Creature
	{
		public virtual void Eat()
		{
			Console.WriteLine("Eating");
		}

		public abstract void Hunt();
	}
}
