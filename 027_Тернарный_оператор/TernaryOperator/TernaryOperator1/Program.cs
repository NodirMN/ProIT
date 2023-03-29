using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = -5;

            string quadrant = x > 0 ? y > 0 ? "I квадрант" : "IV квадрант" : y > 0 ? "II квадрант" : "III квадрант";

            Console.WriteLine(quadrant);

            // Delay
            Console.ReadKey();
        }
    }
}
