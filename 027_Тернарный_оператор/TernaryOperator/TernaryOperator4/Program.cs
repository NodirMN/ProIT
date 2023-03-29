using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Использование условной конструкции if-else
            {
                int a = 1, b = 2, max = 0, min = 0;

                if (a > b) max = 33; else min = 33; // ЕСЛИ: (a > b) ТО: max = 33; ИНАЧЕ: min = 33;

                Console.WriteLine($"max = {max}, min = {min}");
            }

            // Использование тернарного оператора
            {
                int a = 1, b = 2, max = 0, min = 0;

                (a > b ? ref max : ref min) = 33;   // ЕСЛИ: (a > b) ТО: max = 33; ИНАЧЕ: min = 33;

                Console.WriteLine($"max = {max}, min = {min}");
            }

            // Delay
            Console.ReadKey();
        }
    }
}
