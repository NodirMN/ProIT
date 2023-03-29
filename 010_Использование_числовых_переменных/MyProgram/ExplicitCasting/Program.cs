using System;

namespace ExplicitCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOfGreaterType = 256; // Преобразование int в byte
            byte valueOfLowerType = (byte)valueOfGreaterType;

            Console.WriteLine(valueOfGreaterType);
            Console.WriteLine(valueOfLowerType);

            // Delay
            Console.ReadKey();
        }
    }
}
