using System;

namespace ThreeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,,] array = new byte[3, 3, 3]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                },
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                }
            };

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    for (int k = 0; k < array.GetLength(2); k++)
                        Console.Write($"{array[i, j, k]} ");

            // Delay
            Console.ReadKey();
        }
    }
}
