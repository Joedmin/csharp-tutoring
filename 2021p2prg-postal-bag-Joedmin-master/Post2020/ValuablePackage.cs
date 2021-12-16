namespace Post2020
{
	public class ValuablePackage : Package, IValuable
	{
		public int Value { get; set; }
		public ValuablePackage(string Recipient, string Sender, int Weigth, int Value, bool Registered = false, int Price = 100) : base(Recipient, Sender, Weigth, Registered, (int)(Price + (Value * 0.1)))
		{
			this.Value = Value;
		}

		public override string ToString()
		{
			return "V" + base.ToString() + $" Value:{Value}";
		}
	}
}
