using System;
using System.Collections.Generic;
using System.Linq;

namespace Kolekce
{
	class Program
	{
		static void Main(string[] args)
		{
			var animal = new Animal("Rex", "Black", 3);
			animal.Hunt();
			animal.MakeNoise();
			var dog = new Dog("Aa", "yellow", 5, "meat", "bernandýn");
			dog.MakeNoise();
			dog.Hunt();
			var cat = new Cat("BB", "gray", 6, "meat", "bengal");
			cat.MakeNoise();


			var arr = new int?[] { 3, 4, 6, 9 };

			Console.WriteLine(string.Join(", ", arr));
			Console.WriteLine(arr.Length);

			arr[2] = null;


			Console.WriteLine(arr.Length);

			Console.WriteLine(string.Join(", ", arr));


			var arr13 = new int?[arr.Length - 1];

			for (var i = 0; i < arr.Length - 1; i++)
			{
				arr13[i] = arr[i];
			}

			Console.WriteLine(string.Join(", ", arr));
			Console.WriteLine(arr.Length);

			Console.WriteLine(string.Join(", ", arr13));
			Console.WriteLine(arr13.Length);

			var list = new List<int>() { 3, 4, 5, 6, 7, 8, 67 };
			list.Add(3);
			list.Add(4);
			list.Add(6);
			list.Add(9);

			Console.WriteLine(list.Count);

			list.Remove(6);
			Console.WriteLine(list.Count);
			list.Clear();

			list.Add(4);
			list.Add(12);

			Console.WriteLine(list.Count);
			Console.WriteLine(string.Join(", ", list));

			var dict = new Dictionary<string, int>() { { "kniha", 4 } };
			dict.Add("auto", 2);
			dict.Add("budova", 5);


			foreach (var pair in dict)
			{
				Console.WriteLine($"{pair.Key}:{pair.Value}");
			}


			foreach (KeyValuePair<string, int> pair in dict)
			{
				Console.WriteLine($"{pair.Key}:{pair.Value}");
			}


			if (dict.TryGetValue("auto323", out int value))
			{
				Console.WriteLine($"Mam hodnotu : {value}");
			}
			else
			{
				Console.WriteLine("Nemam hodnotu");
			}



			try
			{
				Console.WriteLine($"Mam hodnotu : {dict["budova"]}");
			}
			catch
			{
				Console.WriteLine("nemamm klic");
			}


			var arr1 = new int[,] { { 1, 2, 3, 4 }, { 4, 5, 6, 7 }, { 9, 4, 4, 7 } };
			Console.WriteLine(arr1.Length);
			Console.WriteLine(arr1[1, 1]);

			Console.WriteLine(string.Join(", ", arr.Cast<int>()));


			Console.WriteLine(string.Join(", ", list.Where(i => i % 2 != 0)));

			var arr2 = new Animal[] { new Dog("Rex", "gold", 3, "meat", "vlcak"), new Cat("Cat", "black", 7, "meat", "bengal"), new Mammal("Petr", "yellow", 9, "meat") };

			foreach (var item in arr2)
			{
				Console.WriteLine(item.Name);
			}

			Console.WriteLine(string.Join(", ", arr2.Select(i => i.GetRandomString())));



			Console.WriteLine(list);
			Console.WriteLine(list.ToArray());
			Console.WriteLine(list.All(i => i % 2 == 0));

			Console.ReadKey(true);
		}
	}
}
