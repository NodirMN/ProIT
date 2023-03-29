using System;

namespace RawMaterialPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[,] A = new decimal[3, 2]
                {
                    { 5, 4 },
                    { 3, 7 },
                    { 2, 6 }
                };

            decimal[,] B = new decimal[2, 1]
                {
                    { 70 },
                    { 50 }
                };

            decimal[] C = { 80, 140, 60 };

            decimal[,] Z = new decimal[3, 1];

            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                    Z[i, 0] += A[i, j] * B[j, 0];

            decimal P = 0;

            for (int i = 0; i < Z.GetLength(0); i++)
                P += C[i] * Z[i, 0];

            Console.WriteLine($"Общая стоимость сырья = {P}");

            // Delay
            Console.ReadKey();
        }
    }
}
