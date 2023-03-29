using System;

namespace Circumference
{
    class Program
    {
        static void Main(string[] args)
        {
            //const double pi = 3.14;
            double d = 3, l = Math.PI * d; // pi * d; // см.

            Console.WriteLine($"Длина окружности с диаметром {d} см., равна {l} см.");

            // Delay
            Console.ReadKey();
        }
    }
}
