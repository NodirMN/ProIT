using System;

namespace XOR
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true, y = true, result = x ^ y;
            Console.WriteLine($"1. {x,-5} ^ {y,-5} = {result,-5}");

            x = y = false;
            Console.WriteLine($"2. {x,-5} ^ {y,-5} = {x ^ y,-5}");

            result = (x = true) ^ y;
            Console.WriteLine($"3. {x,-5} ^ {y,-5} = {result,-5}");

            (x, y) = (y, x);
            Console.WriteLine($"4. {x,-5} ^ {y,-5} = {x ^ y,-5}");

            // Delay
            Console.ReadKey();
        }
    }
}
