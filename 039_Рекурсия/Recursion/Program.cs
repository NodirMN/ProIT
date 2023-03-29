using System;

namespace Recursion
{
    class Program
    {
        static void Operation(int counter)
        {
            counter--;
            Console.WriteLine("A: {0}", counter);

            if (counter != 0) 
                Operation(counter);

            Console.WriteLine("B: {0}", counter);
        }

        static void Main()
        {
            Operation(2);

            // Delay
            Console.ReadKey();
        }
    }
}
