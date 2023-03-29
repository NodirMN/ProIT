using System;

namespace EvidenceConditionalDisjunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            bool simpleLogicResult = true | false | (firstNumber++ > 0);
            Console.WriteLine($"firstNumber = {firstNumber}");

            int secondNumber = 0;
            bool shortCircuitResult = true || false || (secondNumber++ > 0);
            Console.WriteLine($"secondNumber = {secondNumber}");

            // Delay
            Console.ReadKey();
        }
    }
}
