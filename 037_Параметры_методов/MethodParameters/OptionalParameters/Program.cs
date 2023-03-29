using System;

namespace OptionalParameters
{
    class Program
    {
        static void Method(int a, int b, int c, int d = 3, int e = 4, int f = 5)
        {
            Console.WriteLine($"{a} {b} {c} {d} {e} {f}");
        }

        static void Main(string[] args)
        {
            Method(0, 1, 2);

            // Delay
            Console.ReadKey();
        }
    }
}
