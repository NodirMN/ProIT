using System;

namespace TextProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            byte apples = 16; // штук
            byte pears = 16;  // штук

            byte fruits = (byte)(apples + pears); // штук

            Console.WriteLine(fruits);

            // Задержка
            Console.ReadKey();
        }
    }
}
