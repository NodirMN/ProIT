using System;
using System.Numerics;

namespace FactorialLoop
{
    class Program
    {
        static BigInteger Factorial(BigInteger number)
        {
            BigInteger intermediateResult = 1;

            for (BigInteger factor = 2; factor <= number; factor++)
            {
                intermediateResult = intermediateResult * factor;
            }

            return intermediateResult;
        }

        static void Main()
        {
            BigInteger number = 3;
            BigInteger factorial = Factorial(number);
            Console.WriteLine($"{number}! = {factorial}");

            // Delay
            Console.ReadKey();
        }
    }
}
