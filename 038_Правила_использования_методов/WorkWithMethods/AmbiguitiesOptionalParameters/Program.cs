using System;

namespace AmbiguitiesOptionalParameters
{
    class Program
    {
        static void Sum(int a = 0, int b = 0)
        {
            Console.WriteLine(a + b);
        }

        static void Sum(int a = 0, int b = 0, int c = 0)
        {
            Console.WriteLine(a + b + c);
        }

        static void Main(string[] args)
        {
            //Sum();  // Неоднозначность
            //Sum(1); // Неоднозначность

            Sum(1, 2);
            Sum(1, 2, 3);

            // Delay
            Console.ReadKey();
        }
    }
}
