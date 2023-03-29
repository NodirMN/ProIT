using System;

namespace ImplicitlyTypedLocalVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var variable = "Hello world!";

            Console.WriteLine(variable);

            // Delay
            Console.ReadKey();
        }
    }
}
