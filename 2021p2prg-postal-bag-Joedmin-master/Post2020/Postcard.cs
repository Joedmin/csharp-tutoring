namespace Post2020
{
	public class Postcard : Consignment
	{
		public string Sender;
		public bool Registered;
		public Postcard(string Sender, string Recipient, bool Registered = false) : base(2, Recipient)
		{
			this.Sender = Sender;
			this.Registered = Registered;
		}

		public override string ToString()
		{
			if (Registered)
			{
				return "CAR" + base.ToString() + "REG";
			}
			return "CAR" + base.ToString();
		}
	}
}
