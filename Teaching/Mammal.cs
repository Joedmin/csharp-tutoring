namespace Teaching
{
	class Mammal : Animal
	{
		public string TypeOfFood { get; }

		public Mammal(string name, string color, int age, string food) : base(name, color, age)
		{
			TypeOfFood = food;
		}

		public void Rename(string name)
		{
			Name = name;
		}
	}
}
