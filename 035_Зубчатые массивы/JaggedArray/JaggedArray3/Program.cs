using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] array0 = new byte[2, 5], array1 = new byte[4, 7], array2 = new byte[3, 6],
                    array3 = new byte[8, 2], array4 = new byte[5, 9], array5 = new byte[4, 2],
                    array6 = new byte[2, 5], array7 = new byte[4, 7], array8 = new byte[3, 6],
                    array9 = new byte[8, 2], array10 = new byte[5, 9], array11 = new byte[4, 2];

            byte[,][,] ja1 = new byte[3, 2][,] { { array0, array1 }, { array2, array3 }, { array4, array5 } };
            byte[,][,] ja2 = new byte[3, 2][,] { { array6, array7 }, { array8, array9 }, { array10, array11 } };

            byte[][,][,] jaggedArray = new byte[2][,][,] { ja1, ja2 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
                {
                    for (int k = 0; k < jaggedArray[i].GetLength(1); k++)
                    {
                        for (int l = 0; l < jaggedArray[i][j, k].GetLength(0); l++)
                        {
                            for (int m = 0; m < jaggedArray[i][j, k].GetLength(1); m++)
                            {
                                Console.Write($"{jaggedArray[i][j, k][l, m]} ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                    }
                }
            }

            // Delay
            Console.ReadKey();
        }
    }
}
