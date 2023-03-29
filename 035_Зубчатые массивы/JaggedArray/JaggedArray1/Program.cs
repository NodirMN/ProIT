using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] array0 = { { 1, 2, 3 },
                               { 4, 5, 6 } };

            byte[,] array1 = { { 1, 2, 3, 4, 5 },
                               { 6, 7, 8, 9, 0 } };

            byte[,] array2 = { { 1, 2 },
                               { 3, 4 } };

            byte[][,] array = new byte[3][,] { array0, array1, array2 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].GetLength(0); j++)
                {
                    for (int k = 0; k < array[i].GetLength(1); k++)
                    {
                        Console.Write($"{array[i][j, k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Delay
            Console.ReadKey();
        }
    }
}
