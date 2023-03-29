using System;

namespace Negation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Отрицание {true} = {!true}, а отрицание {false} = {!false}");

            bool x = true, y = false;

            Console.WriteLine($"Отрицание {x} = {!x}, а отрицание {y} = {!y}");

            bool notX = !x, notY = !y;

            Console.WriteLine($"Отрицание {x} = {notX}, а отрицание {y} = {notY}");

            // Delay
            Console.ReadKey();
        }
    }
}
