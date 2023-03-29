using System;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int index = 0; index < array.Length; index++)
            {
                Console.Write($"{array[index]} ");
            }

            // Delay
            Console.ReadKey();
        }
    }
}
