using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Array.Reverse(array);

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
