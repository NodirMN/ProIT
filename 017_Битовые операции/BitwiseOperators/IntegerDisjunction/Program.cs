using System;

namespace IntegerDisjunction
{
    class Program
    {
        static void Main(string[] args)
        {
            byte port = 0b_0000_1011;   // 0B Hex = 11 Dec 
            Console.WriteLine($"port = {port:X2} = {port}");

            byte mask = 0b_0000_0100;   // 04 Hex = 4 Dec
            Console.WriteLine($"mask = {mask:X2} = {mask}");

            port = (byte)(port | mask); // 0F Hex = 15 Dec
            Console.WriteLine($"port = {port:X2} = {port}");

            // Delay
            Console.ReadKey();
        }
    }
}
