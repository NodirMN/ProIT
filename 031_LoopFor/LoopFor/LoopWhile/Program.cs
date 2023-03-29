using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int index = 0;

            while (index < array.Length)
            {
                Console.Write($"{array[index]} ");
                index++;
            }

            // Delay
            Console.ReadKey();
        }
    }
}
