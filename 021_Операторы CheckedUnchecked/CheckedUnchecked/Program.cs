using System;

namespace CheckedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.MaxValue;
            int result = unchecked(value + 1);
            Console.WriteLine(result);

            // Delay
            Console.ReadKey();
        }
    }
}
