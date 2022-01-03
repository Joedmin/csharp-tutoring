using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dedicnost
{
	interface IChargeable
	{
		public bool IsCharged { get; }
		public void Recharge();
	}
}
