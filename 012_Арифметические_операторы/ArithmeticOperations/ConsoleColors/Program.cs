using System;

namespace ConsoleColors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White; // Устанавливаем цвет фона
            Console.ForegroundColor = ConsoleColor.Black; // Устанавливаем цвет букв
            Console.WriteLine("Hello world!");

            Console.ForegroundColor ++;
            Console.WriteLine("Hello world!");

            Console.ForegroundColor++;
            Console.WriteLine("Hello world!");

            Console.ForegroundColor++;
            Console.WriteLine("Hello world!");

            // Delay
            Console.ReadKey();
        }
    }
}
