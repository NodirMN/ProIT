using System;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 3, 1, 8, 2, 9, 0, 4, 7, 6 };

            Array.Sort(array);

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
