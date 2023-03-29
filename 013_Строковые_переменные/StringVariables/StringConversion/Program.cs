using System;

namespace StringConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = Convert.ToChar("Hello world!");
            Console.WriteLine(letter);

            string sentence = Convert.ToString('A');
            Console.WriteLine(sentence);

            // Delay
            Console.ReadKey();
        }
    }
}
