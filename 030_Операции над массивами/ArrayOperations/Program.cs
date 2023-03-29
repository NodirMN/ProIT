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
            byte[] tempArray = new byte[array.Length + 1];
            array.CopyTo(tempArray, 0);
            tempArray[tempArray.Length - 1] = newElement;
            array = tempArray;
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
