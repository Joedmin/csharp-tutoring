using System;

namespace Dedicnost
{
	internal class ElectricGuitar : Guitar, IChargeable
	{
		public string Amplifier { get; set; }
		public bool IsCharged { get; private set; }


		public ElectricGuitar() : base(6, 3)
		{
			IsCharged = true;
		}
		
		public ElectricGuitar(int stringCount, int stringDurability) : base(stringCount, stringDurability)
		{
		}

		public override void Play()
		{
			if (Amplifier is { } && IsCharged)
			{
				base.Play();
				IsCharged = false;
			}
			else if (!IsCharged)
			{
				Console.WriteLine("Battery is empty.");
			}
			if (Amplifier is not { })
			{
				Console.WriteLine("No ampliefier, cannot play.");
			}
		}

		public void Play(string song)
		{
			Console.WriteLine($"Playing {song}");
		}

		public void Recharge()
		{
			Console.WriteLine("*Recharging*");
			IsCharged = true;
		}

		public override string ToString()
		{
			return $"Amplifier: {Amplifier ?? "None"}\nCharged: {IsCharged}\nString Count: {StringCount}";
		}

		public void Fall(bool isGonnaBreak = false)
		{
			if (!isGonnaBreak)
			{
				Console.WriteLine("Guitar survived");
			}
			else
			{ 
				Console.WriteLine("Guitar did not survive");
			}
		}
	}
}
