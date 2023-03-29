using System;

namespace StrongTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            byte variable = 2;

            Console.WriteLine(variable);

            //variable = "Hello"; // Недопустимо

            Console.WriteLine(variable);

            // Delay
            Console.ReadKey();
        }
    }
}
