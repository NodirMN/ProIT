using System;

namespace ParamsParameters
{
    class Program
    {
        static void Method(string text, params int[] elements)
        {
            Console.WriteLine(text);

            for (int i = 0; i < elements.Length; i++)
                Console.Write($"{elements[i]} ");
        }

        static void Main()
        {
            //int[] array = { 1, 2, 3, 4, 5 };

            Method("Numbers", 1, 2, 3, 4, 5);

            // Delay
            Console.ReadKey();
        }
    }
}
