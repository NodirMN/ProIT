using System;

namespace MethodParameters
{
    class Program
    {
        static void Method(int a, string b)
        {
            Console.WriteLine(a + b);
        }

        static void Main(string[] args)
        {
            int a = 0;
            string b = string.Empty;

            Method(a = 5, b = "Hello");

            Method(b: "Hello", a: 5);

            //Method(b = "Hello", a = 5);

            // Delay
            Console.ReadKey();
        }
    }
}
