using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,][,] array = new byte[3, 2][,];

            array[0, 0] = new byte[2, 2] { { 10, 20 }, { 30, 40 } };
            array[0, 1] = new byte[3, 2] { { 50, 60 }, { 70, 80 }, { 90, 99 } };

            array[1, 0] = new byte[2, 2] { { 11, 12 }, { 13, 14 } };
            array[1, 1] = new byte[3, 2] { { 15, 16 }, { 17, 18 }, { 19, 91 } };

            array[2, 0] = new byte[2, 2] { { 21, 22 }, { 23, 24 } };
            array[2, 1] = new byte[3, 2] { { 25, 26 }, { 27, 28 }, { 29, 92 } };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array[i, j].GetLength(0); k++)
                    {
                        for (int l = 0; l < array[i, j].GetLength(1); l++)
                        {
                            Console.Write($"{array[i, j][k, l]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
            }

            // Delay
            Console.ReadKey();
        }
    }
}
