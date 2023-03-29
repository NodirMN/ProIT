using System;

namespace OutParameters
{
    class Program
    {
        static void Method(out int parameter)
        {
            parameter = 0;
            parameter++;
            Console.WriteLine($"parameter = {parameter}");
        }

        static void Main()
        {
            //int variable; // = 0;

            Method(out int variable);

            Console.WriteLine($"variable = {variable}");

            // Delay
            Console.ReadKey();
        }
    }
}
