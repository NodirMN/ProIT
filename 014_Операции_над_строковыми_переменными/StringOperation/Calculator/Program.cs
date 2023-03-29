using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое слагаемое: ");
            string stringAugend = Console.ReadLine();

            Console.Write("Введите второе слагаемое: ");
            string stringAddend = Console.ReadLine();

            int augend = Convert.ToInt32(stringAugend);
            int addend = Convert.ToInt32(stringAddend);

            int sum = augend + addend;

            string result = augend + " + " + addend + " = " + sum;
            Console.WriteLine(result);

            // Delay
            Console.ReadKey();
        }
    }
}
