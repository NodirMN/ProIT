using System;

namespace Priority
{
    class Program
    {
        static void Main(string[] args)
        {
            // Постфиксный инкремент:  x++

            int a = 0, b = a++ * 5;
            Console.WriteLine($"a = {a}, b = {b}");

            int c = 0, d = c++ + 5;
            Console.WriteLine($"c = {c}, d = {d}");

            // Префиксный инкремент:  ++x

            int e = 0, f = ++e * 5;
            Console.WriteLine($"e = {e}, f = {f}");

            int g = 0, h = ++g + 5;
            Console.WriteLine($"g = {g}, h = {h}");

            // Delay
            Console.ReadKey();
        }
    }
}
