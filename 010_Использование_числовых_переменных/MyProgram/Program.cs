using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = sizeof(decimal);

            Console.WriteLine(size);

            // Задержка
            Console.ReadKey();
        }
    }
}
