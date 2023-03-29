using System;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {
                             { 1, 2 },
                             { 3, 4 },
                             { 5, 6 }
                           };

            int numberOfLines = array.GetLength(0), numberOfColumns = array.GetLength(1);

            for (int y = 0; y < numberOfLines; y++)
            {
                for (int x = 0; x < numberOfColumns; x++)
                {
                    int element = array[y, x];
                    Console.Write($"{element} ");
                }

                Console.WriteLine();
            }

            // Delay
            Console.ReadKey();
        }
    }
}
