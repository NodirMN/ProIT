using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вариант 1
            {
                byte[] array0 = new byte[] { 1, 2, 3 };
                byte[] array1 = new byte[] { 1, 2, 3, 4, 5 };
                byte[] array2 = new byte[] { 1, 2 };

                byte[][] array = new byte[3][] { array0, array1, array2 };

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *= 2;
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // Вариант 2
            {
                byte[] array0 = new byte[] { 1, 2, 3 };
                byte[] array1 = new byte[] { 1, 2, 3, 4, 5 };
                byte[] array2 = new byte[] { 1, 2 };

                byte[][] array = { array0, array1, array2 };

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *= 2;
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // Вариант 3
            {
                byte[] array0 = new byte[] { 1, 2, 3 };
                byte[] array1 = new byte[] { 1, 2, 3, 4, 5 };
                byte[] array2 = new byte[] { 1, 2 };

                byte[][] array = new byte[3][];

                array[0] = array0;
                array[1] = array1;
                array[2] = array2;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *= 2;
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // Вариант 4
            {
                byte[][] array = new byte[3][]
                {
                    new byte[] { 1, 2, 3 },
                    new byte[] { 1, 2, 3, 4, 5 },
                    new byte[] { 1, 2 }
                };

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *= 2;
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // Вариант 5
            {
                byte[][] array =
                {
                    new byte[] { 1, 2, 3 },
                    new byte[] { 1, 2, 3, 4, 5 },
                    new byte[] { 1, 2 }
                };

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *= 2;
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // Вариант 6
            {
                byte[][] array = new byte[3][];
                array[0] = new byte[] { 1, 2, 3 };
                array[1] = new byte[] { 1, 2, 3, 4, 5 };
                array[2] = new byte[] { 1, 2 };

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        array[i][j] *= 2;
                        Console.Write($"{array[i][j]} ");
                    }
                    Console.WriteLine();
                }
            }

            // Delay
            Console.ReadKey();
        }
    }
}
