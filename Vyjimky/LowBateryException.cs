using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vyjimky
{
	internal class LowBateryException : Exception
	{
		public LowBateryException(string message) : base(message)
		{

		}

		public LowBateryException() : base("Batery level is low. Please charge now.")
		{
		}
	}
}
