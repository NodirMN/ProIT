using System;

namespace ArrayOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int length = Convert.ToInt32(Console.ReadLine());
            byte[] array = new byte[length];
            int index = 0;

            while (index < array.Length)
            {
                array[index] = (byte)index;
                Console.Write($"{array[index]}, ");
                index++;
            }

            Console.Write($"\nВведите значение нового элемента: ");
            byte newElement = Convert.ToByte(Console.ReadLine());

            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = newElement;

            index = 0;

            while (index < array.Length)
            {
                Console.Write($"{array[index]}, ");
                index++;
            }

            // Delay
            Console.ReadKey();
        }
    }
}
