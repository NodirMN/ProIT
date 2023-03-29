using System;

namespace Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPart = "Hello", secondPart = "world";

            string text = firstPart + " " + secondPart;

            text += "!"; // text = text + "!";

            Console.WriteLine(text);

            // Delay
            Console.ReadKey();
        }
    }
}
