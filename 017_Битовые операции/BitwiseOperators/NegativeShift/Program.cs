using System;

namespace NegativeShift
{
    class Program
    {
        static void Main(string[] args)
        {
            short value = short.MinValue; // -32768 Dec = 80 00 Hex = 10000000 00000000 Bin
            Console.WriteLine($"1. value = {value,6} Dec = {Convert.ToString(value, 2)} Bin");

            value >>= 14; // 11111111 11111110 Bin
            Console.WriteLine($"2. value = {value,6} Dec = {Convert.ToString(value, 2)} Bin");

            // Delay
            Console.ReadKey();
        }
    }
}
