using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                const int constant = 255;
                byte variable = constant;
                Console.WriteLine(variable);
            }
            {
                const int constant = 256;
                byte variable = unchecked((byte)constant);
                Console.WriteLine(variable);
            }
            {
                const double constant = 255.99;
                byte variable = (byte)constant;
                Console.WriteLine(variable);
            }
            {
                const double constant = 256.0;
                byte variable = unchecked((byte)constant);
                Console.WriteLine(variable);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
