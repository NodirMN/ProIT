using System;

namespace WeakTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic variable = 2;

            Console.WriteLine(variable);

            variable = "Hello"; 

            Console.WriteLine(variable);

            // Delay
            Console.ReadKey();
        }
    }
}
