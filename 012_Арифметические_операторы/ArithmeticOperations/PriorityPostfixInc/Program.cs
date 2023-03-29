using System;

namespace PriorityPostfixInc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = a++ * 5;
            Console.WriteLine($"a = {a}, b = {b}");

            int c = 0, d = c++ * 5 + c;
            Console.WriteLine($"c = {c}, d = {d}");

            // Но, почему тогда не сделать вот так:
            // int c = 0, d = c * 5 + ++c;
            // или просто:
            // int c = 0, d = c * 5 + (c + 1);

            // Delay
            Console.ReadKey();
        }
    }
}
