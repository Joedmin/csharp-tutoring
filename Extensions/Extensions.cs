namespace Extensions
{
    public static class Extensions
    {
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }

        public static bool IsEven(this double num)
        {
            return num % 2 == 0;
        }

        public static bool IsPrime()
        { 
            // udelejte sami
            return true;
        }

        public static bool IsGreaterThan(this int num, int a)
        {
            return num > a;
        }

        public static int WordCount(this string str)
        {
            return str.Split(' ').Length;
        }
    }
}
