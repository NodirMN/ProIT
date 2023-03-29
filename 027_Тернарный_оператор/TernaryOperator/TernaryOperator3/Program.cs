using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            const double PI = 3.14;

            byte result = true ? (byte)(a = 255) : (byte)PI;


            result = (byte)(true ? a = 255 : PI);





            // Delay
            Console.ReadKey();
        }
    }
}
