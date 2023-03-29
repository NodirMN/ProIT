using System;

namespace CharSize
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = sizeof(char);

            Console.WriteLine(size);

            // Delay
            Console.ReadKey();
        }
    }
}
