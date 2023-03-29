using System;

namespace Interpolatio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"1. C format: {2.50:C}");       // Валюта
            Console.WriteLine($"2. D format: {0xFF:D}");       // Десятичное число
            Console.WriteLine($"3. E format: {250000:E2}");    // Экспоненциальный
            Console.WriteLine($"4. F format: {2.5:F2}");       // С фиксированной запятой
            Console.WriteLine($"5. G format: {2.5:G}");        // Общий
            Console.WriteLine($"6. N format: {2500000:N}");    // Numeric
            Console.WriteLine($"7. P format: {0.25:P}");       // Процент
            Console.WriteLine($"8. R format: {0.123456789_12345678:R}");  // Round-Trip
            Console.WriteLine($"9. X format: {255:X}");        // Шестнадцатеричный

            // Delay
            Console.ReadKey();
        }
    }
}
