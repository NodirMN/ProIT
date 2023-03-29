using System;

namespace MultipleConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2;

            if(a > b)
                Console.WriteLine("a > b");
            else
                Console.WriteLine("a <= b");

            // Delay
            Console.ReadKey();
        }
    }
}
