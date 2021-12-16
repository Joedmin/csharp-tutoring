namespace Teaching
{
	abstract class Animal : Creature
	{
		public string Name { get; private set; }	
		public string Color { get; }
		public int Age { get; set; }


		public Animal(string name, string color, int Age)
		{
			Name = name;
			Color = color;
			this.Age = Age;
		}

		public void Rename(string newName)
		{
			Name = newName;
		}
	}
}
