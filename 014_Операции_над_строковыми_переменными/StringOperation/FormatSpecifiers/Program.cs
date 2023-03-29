using System;

namespace FormatSpecifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. C format: {0:C}", 2.50);     // Валюта
            Console.WriteLine("2. D format: {0:D}", 25);       // Десятичное число
            Console.WriteLine("3. E format: {0:E2}", 250000);  // Экспоненциальный
            Console.WriteLine("4. F format: {0:F2}", 2.5);     // С фиксированной запятой
            Console.WriteLine("5. G format: {0:G}", 2.5);      // Общий
            Console.WriteLine("6. N format: {0:N}", 2500000);  // Numeric
            Console.WriteLine("7. P format: {0:P}", 0.25);     // Процент
            Console.WriteLine("8. R format: {0:R}", 2.5);      // Приемо-передача (Round-Trip)
            Console.WriteLine("9. X format: {0:X}", 250);      // Шестнадцатеричный

            // Delay
            Console.ReadKey();
        }
    }
}
