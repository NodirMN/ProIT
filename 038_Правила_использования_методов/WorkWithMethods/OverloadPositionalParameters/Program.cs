using System;

namespace OverloadPositionalParameters
{
    class Program
    {
        static void Method(int a) { Console.WriteLine($"Простой параметр {a}"); }
        static void Method(ref int a) { Console.WriteLine($"Ref параметр {a}"); }
        //static void Method(out int a) { a = 3; Console.WriteLine($"Out параметр {a}"); }
        //static void Method(in int a) { Console.WriteLine($"In параметр {a}"); }

        static void Main(string[] args)
        {
            Method(1);

            int variable = 2;
            Method(ref variable);
            //Method(out variable);
            //Method(in variable);

            // Delay
            Console.ReadKey();
        }
    }
}
