namespace Post2020
{
	public class Package : Consignment
	{
		public bool Registered { get; set; }
		public string Sender { get; set; }
		public int Weigth { get; set; }

		public Package(string Recipient, string Sender, int Weigth, bool Registered = false, int Price = 100) : base(Registered ? Price + Weigth + 10 : Price + Weigth, Recipient)
		{
			this.Registered = Registered;
			this.Sender = Sender;
			this.Weigth = Weigth;
		}

		public override string ToString()
		{
			if (Registered)
			{
				return "PCK" + base.ToString() + "REG";
			}
			return "PCK" + base.ToString();
		}
	}
}
