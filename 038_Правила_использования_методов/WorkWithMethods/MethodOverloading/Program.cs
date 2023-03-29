using System;

namespace MethodOverloading
{
    class Program
    {
        static void Operation() { Console.WriteLine("Метод без аргрументов"); }

        static void Operation(string argument) { Console.WriteLine(argument); }

        static void Operation(int argument) { Console.WriteLine(argument); }

        static void Operation(string argument1, int argument2) { Console.WriteLine(argument1 + argument2); }

        static void Main()
        {
            Operation();
            Operation("text");
            Operation(123);
            Operation("text", 123);

            // Delay
            Console.ReadKey();
        }
    }
}
