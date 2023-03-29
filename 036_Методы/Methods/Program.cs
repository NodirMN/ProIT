using System;

namespace Methods
{
    class Program
    {
        static byte Increment(byte argument)
        {
            argument += 1;
            return argument;
        }

        static void Main(string[] args)
        {
            byte variable = 1;
            byte result = Increment(variable);

            Console.WriteLine(result);

            // Delay
            Console.ReadKey();
        }
    }
}
