namespace Teaching
{
	class Animal
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
	}
}
