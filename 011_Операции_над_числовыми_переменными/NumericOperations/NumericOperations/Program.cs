using System;

namespace NumericOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            byte augend = 1, addend = 2;
            byte sum = (byte)(augend + addend);       // Addition
            
            byte minuend = 5, subtrahend = 3;
            int difference = minuend - subtrahend;    // Subtraction 
            
            byte multiplicand = 2, multiplier = 3;
            int product = multiplicand * multiplier;  // Multiplication
            
            byte dividend = 9, divisor = 2;
            int quotient = dividend / divisor;        // Division (finding quotient)
            int remainder = dividend % divisor;       // Division (finding remainder)

            Console.WriteLine(sum);
            Console.WriteLine(difference);
            Console.WriteLine(product);
            Console.WriteLine(quotient);
            Console.WriteLine(remainder);

            // Delay
            Console.ReadKey();
        }
    }
}
