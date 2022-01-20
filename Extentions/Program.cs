using System;
using System.Linq;

namespace Extentions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 16;
            double myDouble = 3.14;

            Console.WriteLine(Extentions.IsEven(16));
            Console.WriteLine(myNumber.IsEven());
            Console.WriteLine(myDouble.IsEven());

            // mame string, ktery ma vice slov a chceme extention
            // na pocet slov
            var sentence = "Hello world, how are you?";

            Console.WriteLine(sentence.WordCount());

            var arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine(myNumber.IsGreaterThan(17));
        }
    }
}
