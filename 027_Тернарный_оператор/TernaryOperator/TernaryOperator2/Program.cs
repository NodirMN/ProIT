using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, x, y,
                c = true ? x = a : y = b,
                d = true ? x = 0 : y = 1;



            string text = true ? Console.ReadLine() : "Some text";

            // Delay
            Console.ReadKey();
        }
    }
}
