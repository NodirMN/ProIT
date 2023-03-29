using System;
using System.Numerics;

namespace FactorialRecursion
{
    class Program
    {
        static BigInteger Factorial(BigInteger number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        static void Main()
        {
            BigInteger number = 1000;
            BigInteger factorial = Factorial(number);
            Console.WriteLine($"{number}! = {factorial}");

            // Delay
            Console.ReadKey();
        }
    }
}
