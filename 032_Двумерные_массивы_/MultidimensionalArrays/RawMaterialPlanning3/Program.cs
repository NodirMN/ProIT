using System;

namespace RawMaterialPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTypesOfTile, numberOfTypesOfMaterials;
            {
                Console.Write("Введите количество разновидностей плитки: ");
                numberOfTypesOfTile = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество видов сырья для изготовления плитки: ");
                numberOfTypesOfMaterials = Convert.ToInt32(Console.ReadLine());
            }

            decimal[,] A = new decimal[numberOfTypesOfTile, numberOfTypesOfMaterials];
            decimal[,] B = new decimal[numberOfTypesOfMaterials, 1];
            decimal[] C = new decimal[numberOfTypesOfTile];
            decimal[,] Z = new decimal[numberOfTypesOfTile, 1];

            for (int i = 0; i < A.GetLength(0); i++)
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"Введите количество сырья № {j + 1} для плитки № {i + 1} (кг.): ");
                    A[i, j] = Convert.ToDecimal(Console.ReadLine());
                }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                Console.Write($"Введите цену сырья № {i + 1} (руб.): ");
                B[i, 0] = Convert.ToDecimal(Console.ReadLine());
            }

            for (int i = 0; i < C.Length; i++)
            {
                Console.Write($"Введите планируемый объём выпуска плитки № {i + 1} (в штуках.): ");
                C[i] = Convert.ToDecimal(Console.ReadLine());
            }

            // Z CalculateTotalCostOfMaterials (A, B, C, Z)
            {
                for (int i = 0; i < A.GetLength(0); i++)
                    for (int j = 0; j < A.GetLength(1); j++)
                        Z[i, 0] += A[i, j] * B[j, 0];

                decimal P = 0;

                for (int i = 0; i < Z.GetLength(0); i++)
                    P += C[i] * Z[i, 0];

                Console.WriteLine($"Общая стоимость сырья = {P}");
            }
            
            // Delay
            Console.ReadKey();
        }
    }
}
