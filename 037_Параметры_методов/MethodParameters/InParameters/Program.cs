using System;

namespace InParameters
{
    class Program
    {
        static void Method(in int parameter)
        {
            //parameter++;
            Console.WriteLine($"parameter = {parameter}");
        }

        static void Main()
        {
            int variable = 0;

            Method(in variable);

            Console.WriteLine($"variable = {variable}");

            // Delay
            Console.ReadKey();
        }
    }
}
