using System;

namespace NestedMethods
{
    class Program
    {
        static void Main()
        {
            void Method()
            {
                Console.WriteLine("Hello world from nested method!");
            }

            Method();

            // Delay
            Console.ReadKey();
        }
    }
}
