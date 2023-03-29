using System;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const bool A = true;
                bool b = false;
                bool c = A = b;
                Console.WriteLine($"A = {A}, b = {b}, c = {c}");
            }

            {
                const int A = 1;
                int b = 2;
                bool c = b = A;
                Console.WriteLine($"A = {A}, b = {b}, c = {c}");
            }

            // Delay
            Console.ReadKey();
        }
    }
}
