using System;

namespace cuc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            int b = checked(a + 1);
            Console.WriteLine(b);

            int c = int.MaxValue;
            int d = unchecked(c + 1);
            Console.WriteLine(d);

            int e = int.MinValue;
            int f = checked(e - 1);
            Console.WriteLine(f);

            // Delay.
            Console.ReadKey();
        }
    }
}
