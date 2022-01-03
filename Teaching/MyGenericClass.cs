using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekce
{
	public class MyGenericClass<T> where T : IPet
	{
		public T Value;

		public MyGenericClass(T value)
		{
			Value = value;
		}

		public void PrintValue()
		{
			Console.WriteLine(Value.GetType());
			Console.WriteLine(Value.ToString());
		}
	}
}
