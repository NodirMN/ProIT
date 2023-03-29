using System;

namespace RoundTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  format: {0}", 0.123456789_12345678);
            Console.WriteLine("R format: {0:R}", 0.123456789_12345678);

            // Delay
            Console.ReadKey();
        }
    }
}
