using System;

namespace RefParameters
{
    class Program
    {
        static void Method(ref int parameter)
        {
            parameter++;
            Console.WriteLine($"parameter = {parameter}");
        }

        static void Main()
        {
            int variable = 0;

            Method(ref variable);

            Console.WriteLine($"variable = {variable}");

            // Delay
            Console.ReadKey();
        }
    }
}
