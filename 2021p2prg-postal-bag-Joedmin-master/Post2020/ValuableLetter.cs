namespace Post2020
{
	class ValuableLetter : Letter, IValuable
	{
		public int Value { get; set; }
		public ValuableLetter(string Recipient, string Sender, int Value, bool Registered = false, int Price = 10) : base(Recipient, Sender, Registered, (int)(Price + (Value * 0.1)))
		{
			this.Value = Value;
			this.Registered = Registered;
		}

		public override string ToString()
		{
			return "V" + base.ToString() + $" Value:{Value}";
		}
	}
}
