using System;

namespace BitwiseComplementOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = ~a;
            int c = b + 1;

            Console.WriteLine($"a = {a}, b = {b}, c = {c}");

            // Delay
            Console.ReadKey();
        }
    }
}
