using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Использование условной конструкции if-else
            {
                int a = 1, b = 2, max;

                if (a > b) max = a; else max = b; // ЕСЛИ: (a > b) ТО: max = a; ИНАЧЕ: max = b;

                Console.WriteLine(max);
            }

            // Использование тернарного оператора
            {
                int a = 1, b = 2, max;

                max = a > b ? a : b;   // ЕСЛИ: (a > b) ТО: max = a; ИНАЧЕ: max = b;

                Console.WriteLine(max);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
