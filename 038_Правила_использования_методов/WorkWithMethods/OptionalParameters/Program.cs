using System;

namespace OptionalParameters
{
    class Program
    {
        //static void Operation() { Console.WriteLine("Метод без аргрументов"); }
        //static void Operation(string argument) { Console.WriteLine(argument); }
        //static void Operation(int argument) { Console.WriteLine(argument); }
        static void Operation(string argument1 = "text", int argument2 = 0)
        {
            if (argument1 == "text" && argument2 == 0)
            {
                Console.WriteLine("Метод без аргрументов");
            }
            else if(argument1 != "text" && argument2 == 0)
            {
                Console.WriteLine(argument1);
            }
            else if (argument1 == "text" && argument2 != 0)
            {
                Console.WriteLine(argument2);
            }
            else
            {
                Console.WriteLine(argument1 + argument2);
            }
        }

        static void Main()
        {
            Operation();
            Operation("new text");
            Operation(argument2: 123);
            Operation("new text", 123);

            // Delay
            Console.ReadKey();
        }
    }
}
