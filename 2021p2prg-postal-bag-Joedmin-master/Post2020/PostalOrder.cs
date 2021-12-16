namespace Post2020
{
	public class PostalOrder : IValuable
	{
		public int Value { get; set; }
		public string Recipient { get; set; }

		public PostalOrder(string Recipient, int Value)
		{
			this.Value = Value;
			this.Recipient = Recipient;
		}
		public override string ToString()
		{
			return $"MON> To:{Recipient} Value:{Value}";
		}
	}
}
