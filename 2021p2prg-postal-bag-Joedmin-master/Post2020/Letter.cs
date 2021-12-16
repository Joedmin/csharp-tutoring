namespace Post2020
{
	public class Letter : Consignment
	{
		public string Sender { get; set; }
		public bool Registered;

		public Letter(string Recipient, string Sender, bool Registered = false, int Price = 10) : base(Registered ? Price + 10 : Price, Recipient)
		{
			this.Sender = Sender;
			this.Registered = Registered;
		}

		public override string ToString()
		{
			if (Registered)
			{
				return "LET" + base.ToString() + "REG";
			}
			return "LET" + base.ToString();
		}
	}
}
