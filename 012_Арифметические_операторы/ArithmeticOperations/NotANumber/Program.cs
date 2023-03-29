using System;

namespace NotANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Все математические операции, содержащие NaN в качестве одного из операндов
            Console.WriteLine(2 + double.NaN);

            // Деление нуля на ноль
            Console.WriteLine(-0d / +0d);

            // Деление бесконечности на бесконечность
            Console.WriteLine(double.NegativeInfinity / double.PositiveInfinity);

            // Умножение нуля на бесконечность
            Console.WriteLine(0 * double.PositiveInfinity);

            // Cложение бесконечности с бесконечностью противоположного знака
            Console.WriteLine(double.NegativeInfinity + double.PositiveInfinity);

            // Возведение в степень
            Console.WriteLine(Math.Pow(6, 2));

            // Вычисление квадратного корня отрицательного числа
            Console.WriteLine(Math.Sqrt(-36));

            // Логарифмирование отрицательного числа
            Console.WriteLine(Math.Log(-36, 6));



            // Delay
            Console.ReadKey();
        }
    }
}
