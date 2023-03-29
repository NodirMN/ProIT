using System;

namespace NegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int negativeNumber = -1;         // 11111111 11111111 11111111 11111111
            uint naturalNumber = 4294967295; // 11111111 11111111 11111111 11111111

            Console.WriteLine(negativeNumber);
            Console.WriteLine(naturalNumber);

            // Проверка. (значения переменных в двоичном представлении)
            Console.WriteLine(Convert.ToString(negativeNumber, 2));
            Console.WriteLine(Convert.ToString(naturalNumber, 2));

            // Delay (Задержка)
            Console.ReadKey();
        }
    }
}
