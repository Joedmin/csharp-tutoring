namespace Kolekce
{
	public interface IPet
	{
		public string Race { get; }
		public string Owner { get; set; }

		public void Eat();
		public void Sleep();
		public void Cuddle();
	}
}
