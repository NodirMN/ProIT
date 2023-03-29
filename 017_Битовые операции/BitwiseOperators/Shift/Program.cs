using System;

namespace Shift
{
    class Program
    {
        static void Main(string[] args)
        {
            byte port = 0b_0000_1111;

            byte value = (byte)(port << 5);

            value >>= 7;

            Console.WriteLine($"value = {value}");

            // Delay
            Console.ReadKey();
        }
    }
}
