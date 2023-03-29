using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte valueOfLowerType = 255;
            int valueOfGreaterType = valueOfLowerType; // Преобразование byte в int

            Console.WriteLine(valueOfLowerType);
            Console.WriteLine(valueOfGreaterType);

            // Задержка
            Console.ReadKey();
        }
    }
}
