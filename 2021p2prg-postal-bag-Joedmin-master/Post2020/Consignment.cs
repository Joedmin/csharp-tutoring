namespace Post2020
{
	public class Consignment
	{
		public int Price { get; set; }
		public string Recipient { get; set; }

		public Consignment(int Price, string Recipient)
		{
			this.Price = Price;
			this.Recipient = Recipient;
		}

		public override string ToString()
		{
			return $"> To:{Recipient} Price:{Price}";
		}
	}
}
