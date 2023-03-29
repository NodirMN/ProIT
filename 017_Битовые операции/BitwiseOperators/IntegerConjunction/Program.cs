using System;

namespace IntegerConjunction
{
    class Program
    {
        static void Main(string[] args)
        {
            byte port = 0b_0000_1111;   // 0F Hex = 15 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            byte mask = 0b_1111_1011;   // FB Hex = 251 Dec
            Console.WriteLine($"mask = {mask:X2} = {mask}");

            port = (byte)(port & mask); // 0B Hex = 11 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            // Delay
            Console.ReadKey();
        }
    }
}
