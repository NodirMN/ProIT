using System;

namespace SimpleParameters
{
    class Program
    {
        static void Method(int parameter)
        {
            parameter++;
            Console.WriteLine($"parameter = {parameter}");
        }

        static void Main()
        {
            int variable = 0;

            Method(variable);

            Console.WriteLine($"variable = {variable}");

            // Delay
            Console.ReadKey();
        }
    }
}
