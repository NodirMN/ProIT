using System;

namespace Interpolatio
{
    class Program
    {
        static void Main(string[] args)
        {
            // BNF: {<interpolationExpression>[,<alignment>][:<formatString>]}

            double interpolationExpression = 0.123456789_12345678;
            const int alignment = 30;

            Console.WriteLine($"8. R format: {interpolationExpression,-alignment:R} : End.");  // Round-Trip

            Console.WriteLine($"8. R format: {interpolationExpression,alignment:R} : End.");  // Round-Trip


            // Delay
            Console.ReadKey();
        }
    }
}
