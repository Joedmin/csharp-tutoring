using System;

namespace Dedicnost
{
	abstract class Guitar
	{
		public int StringCount;
		public int StringDurability;
		public bool IsTuned = true;
		private int TimesPlayed = 0;
		private int TimesPlayedTotal = 0;

		public Guitar(int stringCount, int stringDurability)
		{
			StringCount = stringCount;
			StringDurability = stringDurability;
		}

		public virtual void Play()
		{
			if (StringCount >= StringDurability)
			{
				if (TimesPlayed == 2)
				{
					IsTuned = false;
					Console.WriteLine("*Playing out of tune guitar*");
				}
				else
				{ 
					Console.WriteLine("*Playing*");
				}
				//if (TimesPlayedTotal % 5 == 0 && TimesPlayedTotal != 0)
				//{
					StringCount--;
				//}
				
				TimesPlayed++;
				TimesPlayedTotal++;
			}
			else
			{
				Console.WriteLine("Strings are broken");
			}
		}

		public void RepairString()
		{
			if (StringCount < StringDurability)
			{
				StringCount++;
			}
		}

		public void Tune()
		{
			IsTuned = true;
		}
	}
}