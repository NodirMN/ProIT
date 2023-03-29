using System;

namespace cuc
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int a = int.MaxValue;
                int b = a + 1;
                Console.WriteLine(b);

                unchecked
                {
                    int c = int.MaxValue;
                    int d = c + 1;
                    Console.WriteLine(d);
                }

                int e = int.MinValue;
                int f = e - 1;
                Console.WriteLine(f);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}
