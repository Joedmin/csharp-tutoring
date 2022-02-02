using System;
using System.IO;

namespace Soubory
{
	internal class Program
	{
		static void Main(string[] args)
		{
			File.WriteAllText("soubor.py", "print(\"Hello world!\")\n# tohle je muj komentar");

			var text = File.ReadAllText("soubor.py");
			Console.WriteLine(text);
			File.Delete("soubor.py");

			Directory.CreateDirectory("MojeSlozka");
			File.WriteAllText("MojeSlozka/text.txt", "Hello folder!");
			Directory.Delete("MojeSlozka", true);

			Console.WriteLine(Directory.GetCurrentDirectory());

			Directory.SetCurrentDirectory("../../../../");
			File.WriteAllText("MyFile.txt", "Hello project!");
			Console.WriteLine(Directory.GetCurrentDirectory());

			// Unmanaged Resources
			var writer = new StreamWriter("test.txt");
			writer.Write("ahoj");
			writer.Write("ja pokracuji na stejnem radku");
			writer.WriteLine();
			writer.Write("ahoj, ja pokracuji na novem radku");
			writer.Dispose();

			writer.Write("ahoj, ja pokracuji na novem radku"); // hodi vyjimku

			using (var myWriter = new StreamWriter("novy_test.txt"))
			{
				myWriter.NewLine = "#";
				myWriter.Write("ahoj");
				myWriter.Write("ja pokracuji na stejnem radku");
				myWriter.WriteLine();
				myWriter.Write("ahoj, ja pokracuji na novem radku");
				myWriter.WriteLine();
				myWriter.WriteLine();
				myWriter.Write("konec souboru");
			}

			using var zapisnik = new StreamWriter("novy_test.txt");

			zapisnik.WriteLine();
			zapisnik.Write("ahoj, ja pokracuji na novem radku");
			zapisnik.WriteLine();
			zapisnik.Write("konec souboru");
			zapisnik.WriteLine();
			zapisnik.Write("hehe");

			using var reader = new StreamReader("novy_test.txt");
			Console.WriteLine(reader.ReadLine());
			Console.WriteLine(reader.ReadLine());

			Console.ReadKey();
		}
	}
}
